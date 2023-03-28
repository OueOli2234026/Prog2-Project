using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRobot
{
    class pDestruction : Piece
    {
        public int Destruction { get; set; }
        private static Random rand = new Random();
        public pDestruction()
        {
            int tempo = rand.Next(1, 501);
            NoPiece = $"DE{tempo}";
            if (tempo <= 50)
            {
                Destruction = 20;
            }
            else if (tempo >= 51 && tempo <= 150)
            {
                Destruction = 40;
            }
            else if (tempo >= 151 && tempo <= 300)
            {
                Destruction = 50;
            }
            else
            {
                Destruction = 80;
            }
        }
    }
}
