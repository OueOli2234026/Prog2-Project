using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRobot
{
    class pTransport : Piece
    {
        public int CapaciteTransport { get; set; }
        private static Random rand = new Random();
        public pTransport() 
        {
            int tempo = rand.Next(1, 501);
            NoPiece = $"TR{tempo}";
            if (tempo <= 50)
            {
                CapaciteTransport = 20;
            }
            else if (tempo >= 51 && tempo <= 150)
            {
                CapaciteTransport = 40;
            }
            else if (tempo >= 151 && tempo <= 300)
            {
                CapaciteTransport = 50;
            }
            else
            {
                CapaciteTransport = 80;
            }
        }
    }
}