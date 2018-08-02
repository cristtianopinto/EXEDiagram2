using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    class Chambre
    {
        public string Numero { get; set; }
        public int NombreLits { get; set; }
        public double PrixNuitee { get; set; }

        public Hotel Hotel { get; set;}
        public List<Reservation> Reservations { get; set; }
    }
}
