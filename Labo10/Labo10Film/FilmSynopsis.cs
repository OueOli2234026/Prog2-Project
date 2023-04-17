using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public partial class Film
    {
        public string Synopsis { get; set; }
        public List<string> Genres { get; set; } 
        public Film(string synopsis)
        {
            Synopsis = synopsis;
            Genres = new List<string>();
            Genres.Add("Science-Fiction");
            Genres.Add("Comédie");
            Genres.Add("Romance");
            Genres.Add("Drame");
            Genres.Add("Suspence");
        }
    }
}
