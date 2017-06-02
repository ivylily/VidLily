using System.Web.Mvc;
using Vidlily.Models;
using System.Collections.Generic;
using System.Linq;

namespace Vidlily.Controllers
{
    [RoutePrefix("Movies")]
    public class MoviesController : Controller
    {
        private List<Movie> Movies = new List<Movie>()
        {
            new Movie() { Name = "Resident Evil", Id = 1 },
            new Movie() { Name = "Dirty Water", Id = 2 },
            new Movie() { Name = "No Return", Id = 3 },
            new Movie() {Name = "The 5th element", Id  = 4 }
        };

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "The 5th element"
            };
            return View(movie);
            //return Content("Hellow World!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1 });
        }

        [Route("released/{year}/{month:regex(\\d):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //  Movies
        public ActionResult Index()
        {
            return View(Movies);
        } 
    }
}