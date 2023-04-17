using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Agence
    {
        public void EngagerAstronaute()
        {
            if (rand.Next(1,101) <= 20)
            {
                Astronautes.Add(new Astronaute(BanqueAgence.GenererNom(), Astro_Tache.Medecin));
            }
            else if (rand.Next(1, 101) > 20 && rand.Next(1, 101) <= 40)
            {
                Astronautes.Add(new Astronaute(BanqueAgence.GenererNom(), Astro_Tache.Ingenieur));
            }
            else if (rand.Next(1, 101) > 40 && rand.Next(1, 101) <= 60)
            {
                Astronautes.Add(new Astronaute(BanqueAgence.GenererNom(), Astro_Tache.Capitaine));
            }
            else if (rand.Next(1, 101) > 60 && rand.Next(1, 101) <= 80)
            {
                Astronautes.Add(new Astronaute(BanqueAgence.GenererNom(), Astro_Tache.Scientifique));
            }
            else
            {
                Astronautes.Add(new Astronaute(BanqueAgence.GenererNom(), Astro_Tache.Militaire));
            }
            AfficherAstronaute();
        }

        public void AmeliorerVaisseau()
        {

        }

        public void AcheterVaisseau()
        {

        }

        public void CommencerMission()
        {
            Console.WriteLine("Quel est le nom de votre mission ?");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrer les coordonnées de votre mission | X.Y |");
            double coord = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quel est la date de départ de la mission ?");
            DateTime dateDepart = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Quel est la date d'arrivee prévue ?");
            DateTime dateArrivee = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Quelle est la raison ?");
            string raison = Console.ReadLine();
            Missions.Add(new Mission(nom, coord, dateDepart, dateArrivee, raison));
        }
    }
}
