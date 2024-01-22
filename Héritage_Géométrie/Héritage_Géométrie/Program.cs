﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Héritage_Géométrie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var formes = new List<Forme> {
                new Cercle { Rayon = 3 },
                new Rectangle { Longueur = 4, Largeur = 3 },
                new Carre { Longueur = 3 },
                new Triangle { A = 4, B = 5, C = 6 }
            };

            foreach (Forme forme in formes)
            {
                Console.WriteLine(forme);
                
            }
            Console.ReadLine();
        }
    }
}

