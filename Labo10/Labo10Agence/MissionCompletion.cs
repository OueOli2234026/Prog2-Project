using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Mission
    {
        public void CompleterMission()
        {
            Statut = "Terminée";
            Console.WriteLine($"La mission est {Statut}");
        }
    }
}
