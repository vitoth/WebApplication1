using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal
{
    public interface IMovieFilter
    {
        //prosljeđujem interfaceu konkretan objekt kao kriterij
        bool Pass(Movie movie);
    }
}
