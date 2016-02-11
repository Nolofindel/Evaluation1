using System;

namespace ChasseurDeTetes.Metier
{
    public class Activite 
   {
        public Activite(sbyte idActivite)
        {
            IdActivite = idActivite;
        }

        public sbyte IdActivite {get; set;}
       public string LibelleActivite {get; set;}
   
   }
}