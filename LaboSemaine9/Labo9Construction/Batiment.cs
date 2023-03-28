using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo9Construction
{
    class Batiment
    {
        public int EtatBatiment { get; set; }
        public string Coordonnee { get; set; }
        public int RessourceNecessaire { get; set; }
        public const int ETAT_MAX = 300;
        private static Random rand = new Random();
        public Batiment()
        {
            EtatBatiment = rand.Next(1,301);
            if (EtatBatiment < 150)
            {
                RessourceNecessaire = EtatBatiment;
            }
            else
            {
                RessourceNecessaire = ETAT_MAX - EtatBatiment;
            }
            Coordonnee = $"( |{rand.Next(0, 101)} , {rand.Next(0, 101)}| )";
        }

        public override string ToString()
        {
            string infoBatiment = "";
            if (EtatBatiment < 150)
            {
                infoBatiment = $"ÉTAT DU BATIMENT | {EtatBatiment}/{ETAT_MAX} / COORDONNÉE | {Coordonnee} / RESSOURCE NÉCESSAIRE À ENLEVER | {RessourceNecessaire}\n";
            }
            else
            {
                infoBatiment = $"ÉTAT DU BATIMENT | {EtatBatiment}/{ETAT_MAX} / COORDONNÉE | {Coordonnee} / RESSOURCE NÉCESSAIRE À RAJOUTER | {RessourceNecessaire}\n";
            }
            return infoBatiment;
        }
    }
}
