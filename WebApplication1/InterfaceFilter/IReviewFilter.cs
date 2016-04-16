using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal
{
    public interface IReviewFilter
    {
        //prosljeđujem interfaceu konkretan objekt kao kriterij
        bool Pass(Review review);
    }
}
