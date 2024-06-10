using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Data;
using KhumaloCraft.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace KhumaloCraft.Controllers
{
    [Authorize(Roles = "seller, admin, client")]
    public class OrderController : Controller
    {
        private readonly KhumaloCraftDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(KhumaloCraftDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Order
        public async Task<IActionResult> Index()
        {
            var khumaloCraftDbContext = _context.Orders.Include(o => o.User);
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return Unauthorized();
            }
            var userRoles = await _userManager.GetRolesAsync(currentUser);

            IQueryable<Order> orders = _context.Orders.Include(o => o.User);

            if (!userRoles.Contains("admin"))
            {
                // If the user is not an admin, filter the orders to only include their orders
                orders = orders.Where(o => o.User != null && o.User.Id == currentUser.Id);
            }

            return View(await orders.ToListAsync());
            //return View(await khumaloCraftDbContext.ToListAsync());
        }

        // GET: Order/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails) // Include the related OrderDetails
                .ThenInclude(od => od.Product) // Include the related Product entities
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // AddToCart
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // Handle the case where the user is not authenticated
                return Unauthorized();
            }

            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                // Handle the case where the product doesn't exist
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.UserID == user.Id && o.Status == "In Cart");

            if (order == null)
            {
                // If the user doesn't have an "In Cart" order, create one
                order = new Order { UserID = user.Id, Status = "In Cart", OrderDetails = new List<OrderDetail>() };
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
            }

            var orderDetail = order.OrderDetails?.FirstOrDefault(od => od.ProductID == productId);
            if (orderDetail == null)
            {
                // If the product isn't in the order yet, add it
                orderDetail = new OrderDetail { OrderID = order.OrderID, ProductID = productId, Quantity = quantity, SubTotal = (decimal)(product.Price * quantity) };
                _context.OrderDetails.Add(orderDetail);
            }
            else
            {
                // If the product is already in the order, increment the quantity
                orderDetail.Quantity += quantity;
                orderDetail.SubTotal = (decimal)(product.Price * orderDetail.Quantity);
            }

            // Update the total of the order
            order.Total = order.OrderDetails?.Sum(od => od.SubTotal) ?? 0;

            // Decrease the stock of the product
            product.Stock -= quantity;

            await _context.SaveChangesAsync();

            return RedirectToAction("ViewCart", "Order");
        }

        //UpdateCart
        [HttpPost]
        public async Task<IActionResult> UpdateCart(int orderDetailId, int quantity)
        {
            var orderDetail = await _context.OrderDetails
                .Include(od => od.Product)
                .Include(od => od.Order) // Include the related Order
                .FirstOrDefaultAsync(od => od.OrderDetailID == orderDetailId);
            if (orderDetail == null)
            {
                // Handle the case where the order detail doesn't exist
                return NotFound();
            }

            // Store the old quantity
            int oldQuantity = orderDetail.Quantity;

            if (quantity <= 0)
            {
                // If the quantity is 0 or less, remove the order detail
                _context.OrderDetails.Remove(orderDetail);
            }
            else
            {
                // Otherwise, update the quantity
                orderDetail.Quantity = quantity;
                if (orderDetail.Product == null)
                {
                    // Handle the case where the product doesn't exist
                    return NotFound();
                }
                orderDetail.SubTotal = (decimal)(orderDetail.Product.Price * quantity);
            }

            await _context.SaveChangesAsync();

            if (orderDetail.Order == null)
            {
                return NotFound();
            }

            // Explicitly load the OrderDetails of the Order from the database
            _context.Entry(orderDetail.Order).Collection(o => o.OrderDetails).Load();

            // Update the total of the order
            orderDetail.Order.Total = orderDetail.Order.OrderDetails.Sum(od => od.SubTotal);

            // Update the stock of the product
            if (orderDetail.Product != null)
            {
                orderDetail.Product.Stock += oldQuantity - quantity;
            }
            else
            {
                // Handle the case where the product doesn't exist
                return NotFound();
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("ViewCart", "Order");
        }


        //ViewCart
        public async Task<IActionResult> ViewCart()
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);

            // Get the user's current order (cart)
            #nullable disable
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product) // Include the related Product entities
                .FirstOrDefaultAsync(o => o.UserID == user.Id && o.OrderDate == null);

            if (order == null)
            {
                return View(new Order()); // Return an empty Order if the cart is empty
            }

            return View(order);
        }

        //FinalizeOrder
        [HttpPost]
        public async Task<IActionResult> FinalizeOrder(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(o => o.OrderID == orderId);

            if (order == null)
            {
                // Handle the case where the order doesn't exist
                return NotFound();
            }

            // Calculate the total price of the order
            order.Total = order.OrderDetails.Sum(od => od.SubTotal);

            // Set the order date to the current date
            order.OrderDate = DateTime.Now;

            // Set the order status to "Placed"
            order.Status = "Placed";

            // Set the order number to the current timestamp
            order.OrderNumber = DateTime.Now.Ticks.ToString();

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Order");
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                return NotFound();
            }

            order.Status = "Confirmed";
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // GET: Order/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,UserID,OrderDate,Total")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", order.UserID);
            return View(order);
        }

        // GET: Order/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Get the list of users
            var users = await _userManager.Users.ToListAsync();

            // Create a list of select items
            ViewBag.UserID = users.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            });

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            ViewBag.UserID = new SelectList(users, "Id", "UserName", order.UserID);
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,UserID,OrderDate,Total")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var originalOrder = await _context.Orders.FindAsync(id);
                    if (originalOrder == null)
                    {
                        return NotFound();
                    }

                    originalOrder.OrderDate = order.OrderDate;
                    originalOrder.UserID = order.UserID;
                    originalOrder.Total = order.Total;

                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            // Get the list of users
            var users = await _userManager.Users.ToListAsync();

            // Create a list of select items
            ViewBag.UserID = users.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            });

            return View(order);
        }

        // GET: Order/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails) // Include the related OrderDetails
                .ThenInclude(od => od.Product) // Include the related Product entities
                .FirstOrDefaultAsync(o => o.OrderID == id);

            if (order != null)
            {
                foreach (var orderDetail in order.OrderDetails)
                {
                    if (orderDetail.Product != null)
                    {
                        // Increase the stock of the product by the quantity of the product in the order
                        orderDetail.Product.Stock += orderDetail.Quantity;
                    }
                }

                _context.Orders.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
