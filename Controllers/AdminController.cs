using KhumaloCraft.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Models;

namespace KhumaloCraft.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private readonly KhumaloCraftDbContext _context;
        public AdminController(KhumaloCraftDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new AdminDashboardViewModel

            {
                TotalCategories = _context.Categories.Count(),
                TotalProducts = _context.Products.Count(),
                TotalUsers = _context.Users.Count(),
                TotalOrders = _context.Orders.Count()
            };

            return View(model);
        }
    }
}
