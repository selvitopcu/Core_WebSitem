using Microsoft.AspNetCore.Mvc;

namespace Core_WebSitem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
