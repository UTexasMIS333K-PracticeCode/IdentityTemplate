using Microsoft.AspNetCore.Mvc;

namespace fa23IdentityTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}