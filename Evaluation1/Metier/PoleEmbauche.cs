using System;

namespace ChasseurDeTetes.Metier
{
   public class PoleEmbauche
   {
        public PoleEmbauche()
        {
        }

        public PoleEmbauche(int id)
        {
            IdPole = id;
        }

        public int IdPole {get; set;}
      public string LibellePole {get; set;}
      
   }
}