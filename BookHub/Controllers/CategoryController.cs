using Microsoft.AspNetCore.Mvc;

namespace BookHub.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
