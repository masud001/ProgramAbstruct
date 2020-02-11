using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    class Tropozoid:TwoDShap
    {
        public Tropozoid(double w, double h) :
       base(w, h, "Tropozoid")
        { }
        // Construct a square.
        public Tropozoid(double x) :
        base(x, "Tropozoid")
        { }
        // Construct a copy of a Rectangle object.
        public Tropozoid(Rectangle ob) : base(ob) { }
        // Return true if the rectangle is square.
        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }
        // Override Area() for Rectangle.
        public override double Area()
        {
            return ((Width * Width)/2)* Height;
        }
    }
}
