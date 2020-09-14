using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHAHmeHmood_MVC5fourth.Models;

namespace SHAHmeHmood_MVC5fourth.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBookDetail()
        {
            Books obj = new Books();
            obj.BookNumber =1 ;
            obj.BookName = "Web Solution Kust";
            obj.BookAuthor = "Mehmood Shah";
            obj.Price = Convert.ToDecimal(300.99);
            obj.Publisher = "Sir Jawad sahib";
            return View(obj);
        }
    }
}