namespace EXEDiagram2
{
    class Avion : Vehicule
    {
        public int NombresMoteurs { get; set; }
        public override int GetVitesseMax()
        {
            return 1200;
        }
    }
}
