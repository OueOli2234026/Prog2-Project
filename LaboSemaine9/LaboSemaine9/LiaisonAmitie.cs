using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienNamespace;
using ChatNamespace;

namespace LiaisonNamespace
{
    class LiaisonAmitie
    {
        public List<Chien> Chiens { get; set; }
        public List<Chat> Chats { get; set; }
        static Random rand = new Random();
        public LiaisonAmitie()
        {
            Chiens = new List<Chien>();
            Chats = new List<Chat>();   
            AjouterChien(new Chien("Dog", (Niveau_Humeur_Dog)rand.Next(0, 4)));
            AjouterChien(new Chien("Doggy", (Niveau_Humeur_Dog)rand.Next(0, 4)));
            AjouterChat(new Chat("Cat", (Niveau_Humeur_Cat)rand.Next(0, 4)));
        }

        public void AjouterChien(Chien dog)
        {
            Chiens.Add(dog);
        }
        public void AjouterChat(Chat cat)
        {
            Chats.Add(cat);
        }

        public string CalculerLiaison()
        {
            Niveau_Humeur_Dog niveauDog = Chiens[0].NiveauHumeurDog;
            Niveau_Humeur_Cat niveauCat = Chats[0].NiveauHumeurCat;
            string amitie = "";
            switch (niveauCat)
            {
                case Niveau_Humeur_Cat.Mauvais when niveauDog == Niveau_Humeur_Dog.Mauvais:
                    amitie = "Le chat et Dog s'attaque. Doggy fuit, aucun n'ami n'a été fait aujourd'hui";
                    break;
                case Niveau_Humeur_Cat.Mauvais when niveauDog == Niveau_Humeur_Dog.Chill:
                    amitie = "Dog à eu peur du chat. Dog deviens ami avec Doggy";
                    break;
                case Niveau_Humeur_Cat.Mauvais when niveauDog == Niveau_Humeur_Dog.Super:
                    amitie = "Dog cour après le chat. Le chat n'est pas content. Doggy commence aussi à courir après le chat ";
                    break;
                case Niveau_Humeur_Cat.Chill when niveauDog == Niveau_Humeur_Dog.Mauvais:
                    amitie = "Le chat regarde Dog, Dog aboie de loin. Le chat le fixe intensément. Doggy est confus de la situation et ne va pas jouer";
                    break;
                case Niveau_Humeur_Cat.Chill when niveauDog == Niveau_Humeur_Dog.Chill:
                    amitie = "les animaux se regarde intensément... C'est une amitié à distance. Doggy lui n'a pas d'ami";
                    break;
                case Niveau_Humeur_Cat.Chill when niveauDog == Niveau_Humeur_Dog.Super:
                    amitie = "Le chat n'attaque pas Dog. Dog et Doggy tourne autour du chat en s'amusant";
                    break;
                case Niveau_Humeur_Cat.Super when niveauDog == Niveau_Humeur_Dog.Mauvais:
                    amitie = "Le chat vient se frotter sur Dog. Dog aboie sur le chat. Le chat fuit et va se frotter sur Doggy";
                    break;
                case Niveau_Humeur_Cat.Super when niveauDog == Niveau_Humeur_Dog.Chill:
                    amitie = "Le chat vient se frotter sur Dog. Dog ne fait rien et est tranquille. Doggy deviens ami avec le chat et Dog";
                    break;
                case Niveau_Humeur_Cat.Super when niveauDog == Niveau_Humeur_Dog.Super:
                    amitie = "Le chat et Dog joue ensemble. Doggy les rejoint";
                    break;
            }
            return amitie;
        }
    }
}
