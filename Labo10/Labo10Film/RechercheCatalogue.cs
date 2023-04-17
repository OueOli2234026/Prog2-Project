using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public partial class Catalogue
    {
        public void RechercherParTitre()
        {
            Console.WriteLine("Entrer le titre d'un film");
            string rechercheTitre = "";
            rechercheTitre = Console.ReadLine();
            Console.WriteLine($"Le film que vous cherchez est : \n");
            foreach (Film film in Films)
            {
                if (rechercheTitre == film.TitreFilm)
                {
                    Console.WriteLine($" {film} \n");
                }
            }
        }

        public void RechercherParActeur()
        {
            Console.WriteLine("Entrer le nom d'un acteur");
            string rechercheActeur = Console.ReadLine();
            Console.WriteLine($"Voici les film contenant cette acteur : \n ");
            foreach (Film film in Films)
            {
                foreach (Acteur acteur in film.Acteurs)
                {
                    if (acteur.Nom.Contains(rechercheActeur))
                    {
                        Console.WriteLine($"{film} \n");
                    }
                }
            }
        }
    }
}
