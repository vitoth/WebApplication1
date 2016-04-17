using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class FilterReviewByUsername : IReviewFilter
    {
        public FilterReviewByUsername(string username)
        {
            this.username = username;
        }

        public bool Pass(Review review)
        {
            return review.Username == this.username;
        }

        private string username;
    }
}