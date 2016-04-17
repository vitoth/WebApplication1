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

        User user;

        public Review(User user, string text, Movie movie)
        {
            this.text = text;
            this.user = user;
            this.movie = movie;
            //Prilikom stvaranje recenzije, konstruktoru recenzije treba proslijediti 
            //registriranog korisnika,referencu na film te tekst recenzije
        }


        public bool ChangeText(string changedText, User user)
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
