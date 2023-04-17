using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            Agence agence = new Agence();
            while (active)
            {
                try
                {
                    agence.AffichageMenu();
                    agence.ChoixMenu(ref active);
                    if(active == false)
                    {
                        Console.WriteLine("Fermeture du menu");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Une erreur est arriver | ERREUR : {ex.Message}");
                    Console.ReadKey();
                }
            }
        }
    }
}
