using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portal;

namespace UnitTests
{
    [TestClass]
    public class ListOfRegisteredUsersContainsOneUserIfUserIsAddedToAnEmptyList
    {
        [TestMethod]
        public void TestMethod1()
        {
            RegisteredUser user = new RegisteredUser("Janko");
            ListOfUsers listOfUsers = new ListOfUsers();
            listOfUsers.Add(user);
            Assert.AreEqual(1, listOfUsers.UserCount);
        }

    }
}
