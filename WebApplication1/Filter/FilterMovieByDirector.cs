using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class FilterMovieByDirector : IMovieFilter
    {
        public FilterMovieByDirector(string director)
        {
            this.director = director;
        }

        public bool Pass(Movie movie)
        {
            return movie.director == this.director;
        }

        private string director;
    }
}