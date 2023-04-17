using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    internal class Production
    {
        public Production()
        {
            Catalogue catalogue = new Catalogue();
            catalogue.AjouterFilm(new Film("Bruh", BanqueNom.GenererNom(), new DateTime(2008, 5, 3)));
            catalogue.AjouterFilm(new Film("Bartelomei", BanqueNom.GenererNom(), new DateTime(2018, 9, 24)));
            catalogue.AjouterFilm(new Film("Bartelomei", BanqueNom.GenererNom(), new DateTime(2018, 9, 24)));
            catalogue.AfficherListFilm();
            
        }
    }
}
