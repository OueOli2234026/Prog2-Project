using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Colorful;


namespace Labo9Affichage
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHumain();
            TestConsole();
            System.Console.ReadKey();
        }
        static void TestHumain()
        {
            System.Console.WriteLine("man".Pluralize());
            System.Console.WriteLine(2302.ToWords());
            System.Console.WriteLine("three bruh moment".Camelize());
            System.Console.WriteLine(5.ToRoman());
            System.Console.WriteLine("three hundred ten".Underscore());
        }
        static void TestConsole()
        {
            int DA = 244;
            int V = 212;
            int ID = 255;
            for (int i = 0; i < 3; i++)
            {
                Colorful.Console.WriteAscii("HASSELHOFF", System.Drawing.Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            }
            StyleSheet style = new StyleSheet(System.Drawing.Color.Red);
            Colorful.Console.WriteStyled("Bruh", style);
        }
        static void TestDNS()
        {
           
        }
    }
}
