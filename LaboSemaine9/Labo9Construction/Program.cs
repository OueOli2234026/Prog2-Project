using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionRobot;

namespace Labo9Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionJeux gestion = new GestionJeux();
            gestion.AssigniationTache();
            Console.ReadKey();
        }
    }
}
