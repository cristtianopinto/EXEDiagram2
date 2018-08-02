using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
