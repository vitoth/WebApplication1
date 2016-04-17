using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Portal
{

    public class ListOfUsers
    {
        public ListOfUsers()
        {
            listOfUsers = new List<User>();
        }

        public bool Add(User user)
        {

            //AkoUListuPokušamoDodatiKorisnikaSImenomKojeVećPostojiListaSeNećePromijeniti 
            if (Contains(user.userName))
                return false;
            
            listOfUsers.Add(user);
            return true;
        }

        public bool Contains(string username)
        {
            foreach (User u in listOfUsers)
            {
                if (username.Equals(u.userName))
                    return true;
            }
            return false;
        }


        public int UserCount
        {
            get { return listOfUsers.Count; }
        }

        List<User> listOfUsers;
    }
}
