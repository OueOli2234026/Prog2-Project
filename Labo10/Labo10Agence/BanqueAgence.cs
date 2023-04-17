using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    public static class BanqueAgence
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
        private static string[] missionS ={
                                            "Delta", "Infinity 5", "Cobalt", "Canada 3", "Nara 6", "Terre 2", "CAQ 15"
                                          };
        private static string[] planeteS ={
                                            "Crème hydratante pour le visage soulage la peau sèche", "ABITIBI 2", "G30425", "Malaros", "U536YS", "K545GE2",
                                            "F35261R"
                                          };

        public static string GenererNom()
        {

            string nom = nomS[rand.Next(nomS.Length)];
            string prenom = prenomS[rand.Next(prenomS.Length)];
            string nomComplet = prenom + " " + nom;
            return nomComplet;
        }
        public static string GenererMission()
        {
            return "";
        }
    }
}
