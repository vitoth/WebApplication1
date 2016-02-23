using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Portal
{

    public class ListOfReviews
    {
        public ListOfReviews()
        {
            listOfReviews = new List<Review>();
        }

        public void AddReview(Review review)
        {
            listOfReviews.Add(review);
        }

        public int ReviewCount()
        {
            return listOfReviews.Count;
        }
        List<Review> listOfReviews;
    }
}
