using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okfks4_voroshilov
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0) throw new Exception();
            Width = width; 
            Height = height;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override string ToString()
        {
            return $"{Height}x{Width}";
        }
    }
}
