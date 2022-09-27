using System.Collections.Generic;
using System.Web.Mvc;
using WILDLY.Models;
using WILDLY.ViewModels;

namespace WILDLY.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { id = 1, Name = "Shrek" },
                new Movie { id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movie
        public ActionResult Random()
        {

            
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}