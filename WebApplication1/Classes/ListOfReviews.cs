using System.Collections.Generic;


namespace Portal
{

    public class ListOfReviews
    {
        public ListOfReviews()
        {
            listOfReviews = new List<Review>();
        }

        public bool AddReview(Review review)
        {
            
            listOfReviews.Add(review);
            return true;
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
