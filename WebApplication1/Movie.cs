using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class Movie
    {
        public readonly string title;
        public readonly string genre;
        public readonly string director;
        public readonly List<string> actors;
        public readonly DateTime year;

        public Movie(string title, DateTime year)
        {
            this.title = title;
            this.year = year;
        }
    }
}