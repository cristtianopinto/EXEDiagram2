using System;
using System.Collections.Generic;
using System.Text;

namespace EXEDiagram2
{
    class Hotel
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }

        public List<Chambre> Chambres { get; set; }
    }
}
