using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiaisonNamespace;

namespace AmitieNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            LiaisonAmitie liaison = new LiaisonAmitie();
            Console.WriteLine($"Le chat est d'humeur {liaison.Chats[0].NiveauHumeurCat}");
            Console.WriteLine($"Dog est d'humeur {liaison.Chiens[0].NiveauHumeurDog}");
            Console.WriteLine(liaison.CalculerLiaison());
            Console.ReadKey();
        }
    }
}
