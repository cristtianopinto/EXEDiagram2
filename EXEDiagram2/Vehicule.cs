using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    class Vehicule
    {
        public int NombreRoues { get; set; }
        public int Marque { get; set; }
        public int Modele { get; set; }

        protected string NumeroSerie  { get; set; }
        internal string NumeroSerie2 { get; set; }//cest pour le projet
    }
}
