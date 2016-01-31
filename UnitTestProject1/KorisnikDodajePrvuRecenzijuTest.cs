using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Portal;
namespace JediničniTestovi
{
    [TestClass]
    public class KorisnikDodajePrvuRecenzijuTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListaRecenzija listaRecenzija = new ListaRecenzija();
            listaRecenzija.DodajRecenziju(new Recenzija());
            Assert.IsTrue(listaRecenzija.DajBrojRecenzijaUListi().Equals(1));
        }
    }
}
