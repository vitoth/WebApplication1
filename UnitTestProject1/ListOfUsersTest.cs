using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portal;
namespace UnitTests
{
    [TestClass]
    public class ListOfUsersTest
    {
        [TestMethod]
        public void ListOfUsers_WhenUserIsAddedToAnEmptyListListContainsOneUser()
        {
            User user = new User("Janko");
            ListOfUsers listOfUsers = new ListOfUsers();
            listOfUsers.Add(user);
            Assert.AreEqual(1, listOfUsers.UserCount);
        }

        [TestMethod]
        public void ListOfUsers_WhenUserIsAddedListIncreasesByOne()
        {
            ListOfUsers list = new ListOfUsers();
            Assert.AreEqual(0, list.UserCount);
            User user = new User("Janko");
            list.Add(user);
            Assert.AreEqual(1, list.UserCount);

        }

        [TestMethod]
        public void ListOfUsers_WhenUserIsAddedHeIsInTheList()
        {
            ListOfUsers list = new ListOfUsers();
            string username = "Janko";
            User user = new User(username);
            list.Add(user);
            Assert.IsTrue(list.Contains(username));
        }

        [TestMethod]
        public void ListOfUsers_AddMethodReturnsFalseIfUsernameAlreadyExists()
        {
            ListOfUsers list = new ListOfUsers();
            User user = new User("Janko");

            Assert.IsTrue(list.Add(user));
            user = new User("Janko");
            
            Assert.IsFalse(list.Add(user));
            Assert.AreEqual(1, list.UserCount);
        }
    }
}
