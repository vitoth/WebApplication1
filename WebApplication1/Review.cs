using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal
{

    public class Review
    {

        public string text { get; private set; }

        public string Username { get { return user.userName; } }

        RegisteredUser user;

        public Review(RegisteredUser regUser, string text, Movie movie)
        {
            this.text = text;
            this.user = regUser;
            //Prilikom stvaranje recenzije, konstruktoru recenzije treba proslijediti 
            //registriranog korisnika,referencu na film te tekst recenzije
        }


        bool ChangeText(string changedText, RegisteredUser user)
        {
            if (user.userName.Equals(this.user.userName))
            {
                text = changedText;
                return true;
            }
            return false;

        }

  
    }
}
