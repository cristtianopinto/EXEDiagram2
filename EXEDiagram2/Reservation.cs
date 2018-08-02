using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    class Reservation
    {
        public DateTime DateDebut { get; set; }
        public int NombreNuitees { get; set; }

        public Chambre Chambre { get; set; }
        public Client Client { get; set; }
    }
}
