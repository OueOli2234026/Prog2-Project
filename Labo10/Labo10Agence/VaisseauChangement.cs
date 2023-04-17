using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Vaisseau
    {
        public void ChangerVitesse()
        {
            if (VitesseActuel > VitesseMax)
            {
                throw new Exception("La vitesse demandée dépasse la vitesse maximale");
            }
            else
            {
                VitesseActuel = VitesseActuel;
            }
        }
    }
}
