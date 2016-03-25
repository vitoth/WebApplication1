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

        public Movie movie { get; private set; }

        RegisteredUser user;

        public Review(RegisteredUser regUser, string text, Movie movie)
        {
            this.text = text;
            this.user = regUser;
            this.movie = movie;
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
