using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo9Construction;

namespace GestionRobot
{
    class GestionJeux
    {
        public Ville Ville { get; set; }
        public List<Batiment> Batiments { get; set; }
        public List<Robot> Robots { get; set; }
        public Usine Usine { get; set; }

        public GestionJeux()
        {
            Ville = new Ville();
            Batiments = new List<Batiment>();
            Robots = new List<Robot>();
            Usine = new Usine();
            for (int i = 0; i < 5; i++)
            {
                AjouterBatiment(new Batiment());
            }
        }
        public void AjouterBatiment(Batiment batiment)
        {
            Batiments.Add(batiment);
        }
        public void AjouterRobot(Robot robot)
        {
            Robots.Add(robot);
        }
        public int[,] ClasserEtat()
        {
            int[,] classificationPiece = new int[Batiments.Count, 3];
            for (int i = 0; i < classificationPiece.GetLength(0); i++)
            {
                for (int j = 0; j < classificationPiece.GetLength(1); j++)
                {
                    if (Batiments[i].EtatBatiment < 150)
                    {
                        classificationPiece[i, 0] = 2;
                        classificationPiece[i, 1] = 3;
                        classificationPiece[i, 2] = 4;
                    }
                    else
                    {
                        classificationPiece[i, 0] = 1;
                        classificationPiece[i, 1] = 3;
                        classificationPiece[i, 2] = 4;
                    }
                }
            }
            return classificationPiece;
        }
        public void AssigniationTache()
        {
            int tempo = 1;
            for (int i = 0; i < Batiments.Count; i++)
            {
                int[,] classificationPiece = ClasserEtat();
                Usine.CreerRobot(classificationPiece, i);
                AjouterRobot(Usine.CreerRobot(classificationPiece, i));
                if (Batiments[i].EtatBatiment < 150)
                {
                    Console.WriteLine($"Batiment {tempo} | {Batiments[i]}Le batiment à besoin d'être détruit. Création de robot destructeur ");
                    Console.WriteLine($"Robot destructeur envoyé pour le batiment {tempo} : \n {Robots[i]}");
                    Console.Write("*********************************************************** \n");
                }
                else
                {
                    Console.WriteLine($"Batiment {tempo} | {Batiments[i]}Le batiment à besoin d'être reconstruit. Création de robot créateur ");
                    Console.WriteLine($"Robot créateur envoyé pour le batiment {tempo} : \n {Robots[i]}");
                    Console.Write("*********************************************************** \n");
                }
                tempo++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }
    }
}
