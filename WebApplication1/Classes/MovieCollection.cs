using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class MovieCollection
    {

        public MovieCollection()
        {
           movies  = new List<Movie>();
        }
        public bool Add(Movie movie)
        {
            //prvo provjera da ne postoji
            if(movies.Contains(movie))
                return false;
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

        public int MovieCount
        {
            get { return movies.Count; }
        }

        public bool Contains(Movie movie)
        {
            //prvo provjera da ne postoji
            if (movies.Contains(movie))
                return true;
            return false;
        }

        List<Movie> movies;
    }
}