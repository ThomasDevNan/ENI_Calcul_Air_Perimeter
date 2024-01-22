using System;

namespace Héritage_Géométrie
{
    internal class Carre : Rectangle
    {
        public override int Largeur { get => base.Longueur ; set => base.Longueur = value; }

        public override string ToString()
        {
            return $"Carré de côté ={Longueur}{Environment.NewLine}{AirEtPerimetre}";
        }

    }
}