using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10Agence
{
    partial class Mission
    {
        public string NomMission { get; set; } 
        public double Destination { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateArrivee { get; set; }
        public string Raison { get; set; }
        public string Statut { get; set; }

        public Mission(string nomMission, double destination, DateTime dateDepart, DateTime dateArrivee,string raison)
        {
            NomMission = nomMission;
            Destination = destination;
            DateDepart = dateDepart;
            DateArrivee = dateArrivee;
            Raison = raison;
            if(dateDepart > DateTime.Now)
            {
                Statut = "non commencée";
            }
            else if (dateDepart < DateTime.Now && dateArrivee > DateTime.Now)
            {
                Statut = "En cours";
            }
            else
            {
                Statut = "Terminée";
            }
        }

        public override string ToString()
        {
            return $@"
|---------------------|MISSION|---------------------|
             NOM | {NomMission} 
     DESTINATION | {Destination} 
          DEPART | {DateDepart}  
         ARRIVÉE | {DateArrivee} 
          RAISON | {Raison}      
          STATUT | {Statut}";
        }

    }
}
