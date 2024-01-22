using System;

namespace Héritage_Géométrie
{
    internal class Rectangle : Forme
    {
        public int Longueur { get; set; }
        public virtual int Largeur { get; set; }

        public override double Aire => Longueur * Largeur;

        public override double Perimetre => (Longueur + Largeur)*2;

        public string AirEtPerimetre => base.ToString();

        public override string ToString()
        {
            return $"Rectangle de longeur {Longueur} et de largeur {Largeur}{Environment.NewLine}{base.ToString()}";
        }
    }
}