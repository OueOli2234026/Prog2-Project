using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNamespace
{
    enum Niveau_Humeur_Dog
    {
        Mauvais,
        Chill,
        Super
    }
    class Chien
    {
        public string NomDog { get; set; }
        public Niveau_Humeur_Dog NiveauHumeurDog { get; set; }

        public Chien(string nom, Niveau_Humeur_Dog niveauHumeurDog)
        {
            NomDog = nom;
            NiveauHumeurDog = niveauHumeurDog;
        }

        public override string ToString()
        {
            return $"CHIEN | Nom : {NomDog}/ Humeur : {NiveauHumeurDog}";
        }
    }
}
