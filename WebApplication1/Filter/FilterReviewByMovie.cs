using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class FilterReviewByMovie : IReviewFilter
    {
        public FilterReviewByMovie(Movie movie)
        {
            this.movie = movie;
        }

        public bool Pass(Review review)
        {
            return review.movie == this.movie;
        }

        private Movie movie;
    }
}