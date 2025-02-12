using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using LAB4_KarolSawicki_w69845;
using static LAB4_KarolSawicki_w69845.Shape;


namespace LAB4_KarolSawicki_w69845
{ 

    class program
    { 
        static void Main(string[] args) 
        {
            List<Shape> figury = new List<Shape>();
            Shape kolo = new Cirlce(12, 22, 80, 12);
            kolo.Draw();
            figury.Add(kolo);

            Shape trojkat = new Triangle(1, 2, 3, 4);
            trojkat.Draw();
            figury.Add(trojkat);

            Shape prostokat = new Rectangle(56, 23, 43, 90);
            prostokat.Draw();
            figury.Add(prostokat);

            Console.WriteLine("Sprawdzenie zawartości listy:\n");

            foreach (Shape shape in figury)
            {
            Console.WriteLine(shape);
            }


        }
    }
}

    