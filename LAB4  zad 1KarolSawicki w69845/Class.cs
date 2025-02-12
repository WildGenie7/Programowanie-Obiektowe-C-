using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_KarolSawicki_w69845
{
    public class Shape
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }

        public Shape(decimal X, decimal Y, decimal Height, decimal Width)
        {
            this.X = X;
            this.Y = Y;
            this.Height = Height;
            this.Width = Width;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Rysuję figurę");
        }

        public override string ToString()
        {
            return $"Figura o współrzędnych ({X}, {Y}) i wymiarach {Width} na {Height}.";
        }

        public class Rectangle : Shape
        {
            public Rectangle(decimal X, decimal Y, decimal Height, decimal Width) : base(X, Y, Height, Width) { }

            public override void Draw()
            {
                Console.WriteLine("Rysuję Rectangle!");
            }
        }

        public class Triangle : Shape
        {
            public Triangle(decimal X, decimal Y, decimal Height, decimal Width) : base(X, Y, Height, Width) { }

            public override void Draw()
            {
                Console.WriteLine("Rysuję Triangle!");
            }
        }

        public class Cirlce : Shape
        {
            public Cirlce(decimal X, decimal Y, decimal Height, decimal Width) : base(X, Y, Height, Width) { }

            public override void Draw()
            {
                Console.WriteLine("Rysuję Circle!");
            }
        }

    }
}
