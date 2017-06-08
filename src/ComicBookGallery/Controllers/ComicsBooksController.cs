using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicsBooksController : Controller
    {
        public ActionResult Detail()
        {
            if( DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            else
            {
                return Content(" Hello from ComicsBooksController ");
            }
            
        }
    }
}