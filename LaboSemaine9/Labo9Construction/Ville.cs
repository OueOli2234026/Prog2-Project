using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo9Construction
{
    class Ville
    {
        public List<Batiment> Batiments { get; set; }
        
        public Ville()
        {
            Batiments = new List<Batiment>();
        }
    }
}
