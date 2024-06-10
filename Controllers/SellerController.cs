using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace KhumaloCraft.Controllers
{
    [Authorize(Roles ="seller, admin")]
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
