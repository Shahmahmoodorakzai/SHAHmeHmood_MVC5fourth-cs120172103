using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHAHmeHmood_MVC5fourth.Controllers
{
    public class HomeController : Controller
    {
        Models.StudentInforEntities db = new Models.StudentInforEntities();
        public ActionResult Index(string searching)
        {
            return View(db.StudentInfoes.Where(X => X.StuName.Contains(searching) || searching==null).ToList());
        }
 
    }
}