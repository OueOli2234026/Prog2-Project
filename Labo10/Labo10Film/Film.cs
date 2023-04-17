using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public partial class Film
    {
        public string TitreFilm { get; set; }
        public string DirecteurFilm { get; set; }
        public DateTime DateSortie { get; set; }
        public List<Acteur> Acteurs { get; set; }
        Random rand = new Random();
        public Film(string titreFilm, string directeurFilm, DateTime date)
        {
            TitreFilm = titreFilm;
            DirecteurFilm = directeurFilm;
            DateSortie = date;
            Acteurs = new List<Acteur>();
            for (int i = 0; i < 30; i++)
            {
                AjouterActeur(new Acteur(BanqueNom.GenererNom(), rand.Next(15, 81)));
            }
        }
        public void AjouterActeur(Acteur acteur)
        {
            Acteurs.Add(acteur);
        }
        private string AfficherActeur()
        {
            string infoActeur = "";
            for (int i = 0; i < 5; i++)
            {
                infoActeur += $"{Convert.ToString(Acteurs[i])} \n";
            }
            return infoActeur;
        }
        public override string ToString()
        {
            return $"TITRE | {TitreFilm}/ DIRECTEUR | {DirecteurFilm}/ DATESORTIE | {DateSortie}\n ACTEURS | ________________________________ \n{AfficherActeur()}";
        }
    }
}
