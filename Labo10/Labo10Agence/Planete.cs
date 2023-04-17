using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    class Planete
    {
        public string NomPlanete { get; set; }
        public int Taille { get; set; }
        public int Distance { get; set; }
        public bool EstViable { get; set; }
        Random rand = new Random();

        public void EstExplorer()
        {
            if (rand.Next(1,101) >= 50)
            {
                throw new Exception($"{NomPlanete} est déjà explorer"); 
            }
            else
            {
                Console.WriteLine($"{NomPlanete} est maintenant explorer");
            }
        }

        public override string ToString()
        {
            return $@"
|---------------------|PLANETE|---------------------|
             NOM | {NomPlanete} 
          TAILLE | {Taille} 
        DISTANCE | {Distance}  
      VIABILITÉE | {EstViable}";
        }
    }
}
