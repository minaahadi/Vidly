using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageindex, String sortBy)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("PageIndex={0}&sortBy={1}", pageindex, sortBy));
        }
    }
}