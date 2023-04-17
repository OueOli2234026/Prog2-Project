using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Labo10Agence
{
    enum Astro_Tache
    {
        Medecin,
        Ingenieur,
        Capitaine,
        Scientifique,
        Militaire
    }
    class Astronaute
    {
        public string NomAstro { get; set; }
        public Astro_Tache Tache { get; set; }
        public Astronaute(string nomAstro, Astro_Tache tache)
        {
            NomAstro = nomAstro;
            Tache = tache;
        }

        public override string ToString()
        {
            return $@"
|---------------------|ASTRONAUTE|---------------------|
             NOM | {NomAstro} 
           TACHE | {Tache}";
        }
    }
}
