using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculateur calculateur = new Calculateur();
            Console.WriteLine("Entrez 1 pour diviser et 2 pour multiplier");
            string choix = Console.ReadLine();
            Console.WriteLine("Quel est votre premier nombre ?");
            int a = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erreur OverFlow");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur");
            }
            Console.WriteLine("Quel est votre deuxième nombre ?");
            int b = 0;
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erreur OverFlow");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erreur");
            }
            if (choix == "1")
            {
                try
                {
                    Console.WriteLine(calculateur.Diviser(a, b));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Une erreur est arrivée lors de la division, Division par 0 impossible");
                }
            }
            else if (choix == "2")
            {
                try
                {

                    Console.WriteLine(calculateur.Multiplier(a, b));
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Une erreur est arrivée lors de la multiplication, Erreur OverFlow");
                }
            }
            Console.ReadKey();
        }
    }
}
