using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portal;
namespace UnitTests
{
    [TestClass]
    public class ListOfUsersTest
    {

        [TestMethod]
        public void ListOfUsers_WhenUserIsAddedListIncreasesByOne()
        {
            ListOfUsers list = new ListOfUsers();
            Assert.AreEqual(0, list.UserCount);
            RegisteredUser user = new RegisteredUser("Janko");
            Assert.AreEqual(1, list.UserCount);

            Assert.IsTrue(list.Add(user));
            user = new RegisteredUser("Janko");

            Assert.IsFalse(list.Add(user));
        }

        [TestMethod]
        public void ListOfUsers_WhenUserIsAddedHeIsInTheList()
        {
            ListOfUsers list = new ListOfUsers();
            string username = "Janko";
            RegisteredUser user = new RegisteredUser(username);
            list.Add(user);
            Assert.IsTrue(list.Contains(username));
        }

        [TestMethod]
        public void ListOfUsers_AddMethodReturnsFalseIfUsernameAlreadyExists()
        {
            ListOfUsers list = new ListOfUsers();
            RegisteredUser user = new RegisteredUser("Janko");

            Assert.IsTrue(list.Add(user));
            user = new RegisteredUser("Janko");
            
            Assert.IsFalse(list.Add(user));
            Assert.AreEqual(1, list.UserCount);
        }
    }
}
