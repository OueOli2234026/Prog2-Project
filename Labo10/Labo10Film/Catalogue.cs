using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public partial class Catalogue
    {
        public List<Film> Films { get; set; }
        public Catalogue()
        {
            Films = new List<Film>();    
        }

        public void AjouterFilm(Film film)
        {
            Films.Add(film);
        }

        public void RemoveFilm(Film film)
        {
            Films.Remove(film);
        }

        public void AfficherListFilm()
        {
            foreach(Film film in Films)
            {
                Console.WriteLine(film.ToString());
            }
        }
    }
}
