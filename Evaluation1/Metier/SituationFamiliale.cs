using System;

namespace ChasseurDeTetes.Metier
{
   public class SituationFamiliale
   {

        public SituationFamiliale(sbyte id)
        {
            IdSituF = id;
        }

        public sbyte IdSituF {get; set;}
      public string LibelleSituF {get; set;}
   
   }
}