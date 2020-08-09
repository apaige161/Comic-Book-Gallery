using Comic_Book_Gallery.Data;
using Comic_Book_Gallery.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //needs to reference the base controllers class
    //needs to be public so the web app can access the controller
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        //instantiate repo with a constructor
        //constructors dont have a return type, also match the class name
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        //index action method - return action result object
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            //return a view
            return View(comicBooks);

        }


        //int? make the int nullable, meaning that if there is no id it will still work
        public ActionResult Detail(int? id)
        {
            //return error if no id
            if(id == null)
            {
                return HttpNotFound();
            }

            //get a comic book from the id
            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            
            //pass in the instance of the comic
            return View(comicBook);
        }
    }
}
