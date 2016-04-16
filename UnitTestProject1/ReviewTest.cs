using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portal;

namespace UnitTests
{
    [TestClass]
    public class ReviewTest
    {
        [TestMethod]
        public void Review_ChangeTextMethodChangesSetsTheValueOfTextToAChangedText()
        {
            Review review = new Review(regUser, text, movie);
            string changedText = "NovaRecenzija";
            review.ChangeText(changedText, regUser);
            Assert.AreEqual(review.text, changedText);
        }

        RegisteredUser regUser = new RegisteredUser("Janko");
        string text = "Recenzija";
        static DateTime year = new DateTime(1999);

        Movie movie = new Movie("Naziv", year);
    }
}
