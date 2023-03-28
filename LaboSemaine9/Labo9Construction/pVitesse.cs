using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRobot
{
    class pVitesse : Piece
    {
        public int VitesseKmH { get; set; }
        static Random rand = new Random();
        public pVitesse()
        {
            int tempo = rand.Next(1, 501);
            NoPiece = $"VI{tempo}";
            if (tempo <= 50)
            {
                VitesseKmH = 40;
            }
            else if (tempo >= 51 && tempo <= 150)
            {
                VitesseKmH = 60;
            }
            else if (tempo >= 151 && tempo <= 300)
            {
                VitesseKmH = 80;
            }
            else
            {
                VitesseKmH = 120;
            }
        }
    }
}
