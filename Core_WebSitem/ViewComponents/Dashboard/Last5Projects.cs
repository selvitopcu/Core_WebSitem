using Microsoft.AspNetCore.Mvc;

namespace Core_WebSitem.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
