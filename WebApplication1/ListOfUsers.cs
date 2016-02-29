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
            listOfUsers = new List<RegisteredUser>();
        }

        public bool Add(RegisteredUser user)
        {

            //AkoUListuPokušamoDodatiKorisnikaSImenomKojeVećPostojiListaSeNećePromijeniti 
            if (Contains(user.userName))
                return false;
            
            listOfUsers.Add(user);
            return true;
        }

        public bool Contains(string username)
        {
            foreach (RegisteredUser u in listOfUsers)
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

        List<RegisteredUser> listOfUsers;
    }
}
