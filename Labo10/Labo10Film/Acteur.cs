using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public class Acteur
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public Acteur(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public override string ToString()
        {
            return $"NOM | {Nom}/ AGE | {Age}";
        }

    }
}
