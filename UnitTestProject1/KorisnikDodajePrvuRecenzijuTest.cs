using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Portal;
namespace UnitTests
{
    [TestClass]
    public class UserAddsFirstReview
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListOfReviews listOfReviews = new ListOfReviews();
            listOfReviews.AddReview(new Review());
            Assert.IsTrue(listOfReviews.ReviewCount().Equals(1));
        }
    }
}
