using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Film
{
    public static class BanqueNom
    {
        private static Random rand = new Random();
        private static string[] nomS = { 
                                         "Poko", "Polo", "Cisco", "Latendresse", "Roy", "Déry", "Aube", "Twilight", "Tremblay", "Savard", 
                                        "Mercier", "Simard", "Laroche", "Vinci", "Lapointe", "Dumas", "Leclair", 
                                        "Ouellette", "Presley", "Smith", "Sandler", "Ferrel", "Franklin", "Legault", 
                                       };
        private static string[] prenomS = {
                                            "Maron", "Bruh", "Bartelomei", "Aaron", "Justine", "Gustave", "Simon-Max", "Erika", 
                                            "Julianne", "Lionel", "Arthur", "Vincent", "Eric", "Rebeka", "Andrew", 
                                            "Tobi", "Walter", "Happy", "Ralph", "Sylvester", "Tanguay", "Nathan", "Emilie", 
                                          };

        public static string GenererNom()
        {
            
            string nom = nomS[rand.Next(nomS.Length)];
            string prenom = prenomS[rand.Next(prenomS.Length)];
            string nomComplet = prenom + " " + nom;    
            return nomComplet;
        }
    }
}
