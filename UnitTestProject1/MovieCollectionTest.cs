using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portal;
namespace UnitTests
{
    [TestClass]
    public class movieCollectionTest
    {


        [TestMethod]
        public void MovieCollection_WhenMovieIsAddedToAnEmptyListListContainsOneMovie()
        {
            movieCollection.Add(movie);
            Assert.AreEqual(1, movieCollection.MovieCount);
        }

        [TestMethod]
        public void MovieCollection_WhenMovieIsAddedListIncreasesByOne()
        {
            Assert.AreEqual(0, movieCollection.MovieCount);
            movieCollection.Add(movie);
            Assert.AreEqual(1, movieCollection.MovieCount);

        }

        [TestMethod]
        public void MovieCollection_WhenMovieIsAddedItIsInTheList()
        {
            movieCollection.Add(movie);
            Assert.IsTrue(movieCollection.Contains(movie));
        }

        [TestMethod]
        public void MovieCollection_AddMethodReturnsFalseIfMovieAlreadyExists()
        {

            Assert.IsTrue(movieCollection.Add(movie));

            Assert.IsFalse(movieCollection.Add(movie));
            Assert.AreEqual(1, movieCollection.MovieCount);
        }

       

        static DateTime year = new DateTime(2008, 1, 1, 1, 0, 0);
        Movie movie = new Movie("Naziv", year);
        MovieCollection movieCollection = new MovieCollection();


    }
}
