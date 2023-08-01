using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_WebSitem.Areas.Writer.ViewCopmonents
{
    public class Notification:ViewComponent
    {
        AnnouncementManager announcementManager=new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values=announcementManager.TGetList().Take(5).ToList();
            return View(values);    
        }
    }
}
