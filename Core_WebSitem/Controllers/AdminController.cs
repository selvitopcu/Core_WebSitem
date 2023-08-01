using Microsoft.AspNetCore.Mvc;

namespace Core_WebSitem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult NewSidebar()
        {
            return PartialView();
        }
    }
}
