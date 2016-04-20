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
        public void ListOfReviews_ReviewWillNotBeAddedIfTheMovieItReviewsIsNotInTheListOfMovies()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            Assert.IsFalse(movieCollection.Contains(movie));
            Assert.IsFalse(listOfReviews.AddReview(new Review(user, text, movie)));
        }

        [TestMethod]
        public void ListOfReviews_AddReviewMethodIncreasesTheNumberOfReviewsByOne()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            listOfReviews.AddReview(new Review(user, text, movie));
            Assert.AreEqual(1, listOfReviews.ReviewCount());
        }

        [TestMethod]
        public void ListOfReviews_GetReviewsMethodReturnsCollectionOfFilteredReviews()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            listOfReviews.AddReview(new Review(user, text,movie));

            FilterReviewByUsername rfu = new FilterReviewByUsername("Janko");
            var filteredReviews = listOfReviews.GetReviews(rfu);

            Assert.AreEqual(1, filteredReviews.Count());
        }

        User user = new User("Janko");
        string text = "Recenzija";

        static DateTime year = new DateTime(2008, 1, 1, 1, 0, 0);
        Movie movie = new Movie("Naziv", year);
        MovieCollection movieCollection = new MovieCollection();

    }
}
