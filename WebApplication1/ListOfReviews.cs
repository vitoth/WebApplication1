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

        public IEnumerable<Review> GetReviews(IReviewFilter filter)
        {
            //primjenit na 
            List<Review> result = new List<Review>();
            foreach (Review r in listOfReviews)
            {
                if (filter.Pass(r))
                    result.Add(r);
            }
            return result;
        }

        public int ReviewCount()
        {
            return listOfReviews.Count;
        }
        List<Review> listOfReviews;
    }
}
