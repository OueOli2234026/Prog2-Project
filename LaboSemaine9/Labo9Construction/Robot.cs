using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRobot
{
    class Robot
    {
        public Piece[] Pieces { get; set; }

        public Robot(Piece[] pieces)
        {
            Pieces = pieces;
        }

        public override string ToString()
        {
            return $"Robot | Piece 1: {Pieces[0].NoPiece} | Piece 2: {Pieces[1].NoPiece} | Piece 3: {Pieces[2].NoPiece} \n";
        }
    }
}
