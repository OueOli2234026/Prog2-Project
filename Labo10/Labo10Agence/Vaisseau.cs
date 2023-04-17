using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    public partial class Vaisseau
    {
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public int VitesseActuel { get; set; }
        public const int VitesseMax = 8000;
        public bool EnOrbite { get; set; }
        public Vaisseau(string nom, int capacite, int vitesseActuel, bool enOrbite)
        {
            Nom = nom;
            Capacite = capacite;
            VitesseActuel = vitesseActuel;
            EnOrbite = enOrbite;
        }

        public void Decollage(double xy, DateTime dateDepart)
        {
            if (EnOrbite == true)
            {
                throw new Exception($"La fusée {Nom} est déjà en orbite"); 
            }
            else
            {
                EnOrbite = true;
                Console.WriteLine($"La fusée {Nom} est maintenant dans l'espace");
            }
        }
        public override string ToString()
        {
            return $@"
|---------------------|VAISSEAU|---------------------|
             NOM | {Nom} 
        CAPACITE | {Capacite} 
         VITESSE | {VitesseActuel}/{VitesseMax}  
          ORBITE | {EnOrbite}";
        }
    }
}
