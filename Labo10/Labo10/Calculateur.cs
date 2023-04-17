using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Calculateur
    {
        public int Diviser(int a, int b)
        {
            int c = 0;
            checked
            {
               c = a / b;
            }
            return c;
        }
        public int Multiplier(int a, int b)
        {
            int c = 0;
            checked
            {
                c = a * b;
            }
            return c;
        }
    }
}
