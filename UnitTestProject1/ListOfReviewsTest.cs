using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Portal;
namespace UnitTests
{
    [TestClass]
    public class ListOfReviewsTest
    {
        [TestMethod]
        public void ListOfReviews_AddReviewMethodIncreasesTheNumberOfReviewsByOne()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            listOfReviews.AddReview(new Review(regUser, text, movie));
            Assert.AreEqual(1, listOfReviews.ReviewCount());
        }

        [TestMethod]
        public void ListOfReviews_GetReviewsMethodReturnsCollectionOfFilteredReviews()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            listOfReviews.AddReview(new Review(regUser, text,movie));

            ReviewFilterByUsername rfu = new ReviewFilterByUsername("Janko");
            var filteredReviews = listOfReviews.GetReviews(rfu);

            Assert.AreEqual(1, filteredReviews.Count());
        }

        RegisteredUser regUser = new RegisteredUser("Janko");
        string text = "Recenzija";
        static DateTime year = new DateTime(1999);

        Movie movie = new Movie("Naziv", year);
        
            
    }
}
