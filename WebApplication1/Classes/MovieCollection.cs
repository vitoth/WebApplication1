using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class MovieCollection
    {
        public bool AddMovie(Movie movie)
        {
            //prvo provjera da ne postoji
            movies.Add(movie);
            return true;
        }

        public IEnumerable<Movie> GetMovies(IMovieFilter filter)
        {
            //primjenit na 
            List<Movie> result = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (filter.Pass(m))
                    result.Add(m);
            }
            return result;
        }

        List<Movie> movies = new List<Movie>();
    }
}