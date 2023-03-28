using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GestionRobot
{
    class Usine
    {
        private static Random rand = new Random();
        public Usine()
        {

        }

        public Robot CreerRobot(int[,] classeProbleme, int index)
        {
            Piece[] pieces = new Piece[3];
            for (int j = 0; j < classeProbleme.GetLength(1); j++)
            {
                switch (classeProbleme[index,j])
                {
                    case 1:
                        pieces[j] = new pConstruction();
                        break;
                    case 2:
                        pieces[j] = new pDestruction();
                        break;
                    case 3:
                        pieces[j] = new pTransport();
                        break;
                    case 4:
                        pieces[j] = new pVitesse();
                        break;
                }
            }
            return new Robot(pieces);
        }
    }
}
