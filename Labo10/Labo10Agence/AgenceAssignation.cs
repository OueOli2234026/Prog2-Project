using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Agence
    {
        public void AssignerMissionEscadron()
        {
            Console.WriteLine("---------|Donner une mission à un escadron|---------");
            Console.WriteLine("À quel escadron voulez-vous donnez une mission | Donner le nombre associé");
            AfficherEscadron();
            int indexEscadron = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est la mission à donner ? | Donner le nombre associé");
            AffichageMission();
            int indexMission = Convert.ToInt32(Console.ReadLine());
            if (Escadrons[indexEscadron].Mission != null)
            {
                throw new Exception("L'escadron possède déjà une mission");
            }
            else
            {
                Escadrons[indexEscadron].Mission = Missions[indexMission];
            }
            AfficherEscadron();
        }

        public void AssignerAstronauteEscadron()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("---------|Donner des astronautes à un escadron| Obligatoire : 5|---------");
                Console.WriteLine("À quel escadron voulez-vous donnez des astronautes | Donner le nombre associé");
                AfficherEscadron();
                int indexEscadron = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qui sont les astronautes à assigner ? | Donner le nombre associé");
                AfficherAstronaute();
                int indexAstronaute = Convert.ToInt32(Console.ReadLine());
                if (Escadrons[indexEscadron].Escouade.Any(astronaute => Escadrons[indexEscadron].Escouade[indexAstronaute].Tache == astronaute.Tache))
                {
                    throw new Exception("Il y a déjà un astronaute avec cette tâche");
                }
                Escadrons[indexEscadron].Escouade[i] = Escadrons[indexEscadron].Escouade[indexAstronaute];

            }

        }

        public void AssignerVaisseauEscadron()
        {
            Console.WriteLine("---------|Donner un vaisseau à un escadron|---------");
            Console.WriteLine("À quel escadron voulez-vous donnez un vaisseau | Donner le nombre associé");
            AfficherEscadron();
            int indexEscadron = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est le vaisseau à assigner ? | Donner le nombre associé");
            AfficherVaisseau();
            int indexVaisseau = Convert.ToInt32(Console.ReadLine());
            if (Escadrons[indexEscadron].Vaisseau != null)
            {
                throw new Exception("L'escadron possède déjà un vaisseau");
            }
            else
            {
                Escadrons[indexEscadron].Vaisseau = Vaisseaus[indexVaisseau];
            }
            AfficherEscadron();
        }
    }
}
