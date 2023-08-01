using Microsoft.AspNetCore.Mvc;

namespace Core_WebSitem.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
