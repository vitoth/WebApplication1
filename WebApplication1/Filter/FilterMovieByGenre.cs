using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class FilterMovieByGenre : IMovieFilter
    {
        public FilterMovieByGenre(string genre)
        {
            this.genre = genre;
        }

        public bool Pass(Movie movie)
        {
            return movie.genre == this.genre;
        }

        private string genre;
    }
}