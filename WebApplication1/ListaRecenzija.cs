using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Portal
{

    public class ListaRecenzija
    {
        public ListaRecenzija()
        {
            listaRecenzija = new List<Recenzija>();
        }

        public void DodajRecenziju(Recenzija recenzija)
        {
            listaRecenzija.Add(recenzija);
        }

        public int DajBrojRecenzijaUListi()
        {
            return listaRecenzija.Count;
        }
        List<Recenzija> listaRecenzija;
    }
}
