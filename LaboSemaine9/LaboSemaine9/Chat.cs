using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNamespace
{
    enum Niveau_Humeur_Cat
    {
        Mauvais,
        Chill,
        Super
    }
    class Chat
    {
        public string NomChat { get; set; }
        public Niveau_Humeur_Cat NiveauHumeurCat { get; set; }
        public Chat(string nomChat, Niveau_Humeur_Cat niveauHumeurCat)
        {
            NomChat = nomChat;
            NiveauHumeurCat = niveauHumeurCat;
        }
    }
}
