using MovieApp.Models;

namespace MovieApp.Services
{
    public class MovieServices
    {
        private MovieContext context;

        public MovieServices(MovieContext context)
        {
            this.context = context;
        }

        public Movie AddMovie(Movie newMovie)
        {
            context.Movies.Add(newMovie);
            return newMovie;
        }
        public List<Movie> AllMovies()
        {
            return context.Movies.ToList();
        }
    }
}
