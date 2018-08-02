using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    public abstract class Vehicule// une class abstract on ne peux pas instancier directement
    {
        public int NombreRoues { get; set; }
        public int Marque { get; set; }
        public int Modele { get; set; }

        protected string NumeroSerie  { get; set; }
        internal string NumeroSerie2 { get; set; }//cest pour le projet

        public abstract int GetVitesseMax();
    }
}
