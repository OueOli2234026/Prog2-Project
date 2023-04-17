using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Agence
    {
        Random rand = new Random();
        public string NomAgence { get; set; }
        public List<Mission> Missions { get; set; }
        public List<Vaisseau> Vaisseaus { get; set; }
        public List<Astronaute> Astronautes { get; set; }
        public List<Escadron> Escadrons { get; set; }
        public List<Planete> Planetes { get; set; }
        public Agence()
        {
            Missions = new List<Mission>();
            Vaisseaus = new List<Vaisseau>();
            Astronautes = new List<Astronaute>();
            Planetes = new List<Planete>();
            Escadrons = new List<Escadron>();
            Missions.Add(new Mission("Destination nouveau Canada", 13453.12332, new DateTime(2022, 1, 5), new DateTime(2029, 4, 6), "Canada go boom"));
            Escadrons.Add(new Escadron("Romano fafar"));

        }
        public void AffichageMenu()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("|******************************MENU AGENCE******************************|");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("1| Voir Vaisseau en orbite      | 2| Voir mission en cours              |");
            Console.WriteLine("3| Améliorer vaisseau           | 4| Engager astronaute                 |");
            Console.WriteLine("5| Acheter un vaisseau          | 6| Commencer une mission              |");
            Console.WriteLine("7| Voir Escadrons               | 8| Assigner mission à une escadron    |");
            Console.WriteLine("9| Assigner Vaisseau à escadron |10| Assigner astronautes à une escadron|");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("|*****************************|11| Quitter|*****************************|");
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        public void AffichageMission()
        {
            if (Missions == null)
            {
                throw new Exception("Il n'y a pas de mission existante pour le momment");
            }
            else
            {
                int i = 0;
                foreach (Mission mission in Missions)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"{i}. | {mission}");
                    Console.WriteLine("-----------------------------------");
                    i++;
                }
            }
        }

        public void AfficherEscadron()
        {
            if (Escadrons == null)
            {
                throw new Exception("La liste d'escadron n'existe pas");
            }
            else if (Escadrons.Count == 0)
            {
                throw new Exception("Il n'y a pas encore d'escadron dans votre base de donné");
            }
            else
            {
                int i = 0;
                foreach (Escadron escadron in Escadrons)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"{i}. | {escadron}");
                    Console.WriteLine("-----------------------------------");
                    i++;
                }
            }
        }

        public void AfficherAstronaute()
        {
            if (Astronautes == null)
            {
                throw new Exception("Il n'y a pas de d'astronaute dans votre base de donnée");
            }
            else
            {
                int i = 0;
                foreach (Astronaute astronaute in Astronautes)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"{i}. | {astronaute}");
                    Console.WriteLine("-----------------------------------");
                    i++;
                }
            }
        }

        public void AfficherVaisseau()
        {
            if (Vaisseaus == null)
            {
                throw new Exception("Il n'y a pas de Vaisseau dans votre base de donnée");
            }
            else
            {
                foreach (Vaisseau vaisseau in Vaisseaus)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine(vaisseau);
                    Console.WriteLine("-----------------------------------");
                }
            }
        }

        public void ChoixMenu(ref bool valide)
        {
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    AfficherVaisseau();
                    break;
                case "2":
                    AffichageMission();
                    break;
                case "3":
                    AmeliorerVaisseau();
                    break;
                case "4":
                    EngagerAstronaute();
                    break;
                case "5":
                    AcheterVaisseau();
                    break;
                case "6":
                    CommencerMission();
                    break;
                case "7":
                    AfficherEscadron();
                    break;
                case "8":
                    AssignerMissionEscadron();
                    break;
                case "9":
                    AssignerVaisseauEscadron();
                    break;
                case "10":
                    AssignerAstronauteEscadron();
                    break;
                case "11":
                    Quitter(ref valide);
                    break;
            }
        }
        public bool Quitter(ref bool valide)
        {
            valide = false;
            return valide;
        }
    }
}
