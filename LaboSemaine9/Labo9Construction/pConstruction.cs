using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRobot
{
    class pConstruction : Piece
    {
        public int Construction { get; set; }
        private static Random rand = new Random();
        public pConstruction()
        {
            int tempo = rand.Next(1, 501);
            NoPiece = $"CO{tempo}";
            if (tempo <= 50)
            {
                Construction = 10;
            }
            else if (tempo >= 51 && tempo <= 150)
            {
                Construction = 20;
            }
            else if (tempo >= 151 && tempo <= 300)
            {
                Construction = 40;
            }
            else
            {
                Construction = 50;
            }
        }
    }
}