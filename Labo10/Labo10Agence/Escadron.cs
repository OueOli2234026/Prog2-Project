using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    class Escadron
    {
        public string NomEscadron { get; set; }
        public List<Astronaute> Escouade { get; set; }
        public Vaisseau Vaisseau { get; set; }
        public Mission Mission { get; set; }
        public Escadron(string nomEscadron)
        {
            Escouade = new List<Astronaute>();
            NomEscadron = nomEscadron;
        }

        public override string ToString()
        {
            string infoAstro = "";
            Escouade.ForEach(astronaute => infoAstro += astronaute.ToString());
            return $"NOM | {NomEscadron} | \n {infoAstro}  \n {Vaisseau}  \n {Mission} ";
        }
    }
}
