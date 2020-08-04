using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //needs to reference the base controllers class
    //needs to be public so the web app can access the controller
    public class ComicBooksController : Controller
    {
        //add action method
        //must type in comicbook/detail to get to the string
        public ActionResult Detail()
        {
            return View();
        }
    }
}