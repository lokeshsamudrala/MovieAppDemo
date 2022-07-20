using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;

namespace MovieApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        // private List<Movie> movies = new List<Movie>();
        private MovieServices movieServices /*= new MovieServices()*/;
        private IConfiguration configuration;
        public MovieController(MovieServices movieServices)
        {
            this.movieServices = movieServices;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            
            return movieServices.AllMovies();
        }

        [HttpPost]
        public Movie Post(Movie newMovie)
        {
            return movieServices.AddMovie(newMovie);
        }
        /*[HttpPost("secondPost")]
        public Movie PostTo(Movie newMovie)
        {
            return movieServices.AddMovie(newMovie);
        }*/

    }
}
