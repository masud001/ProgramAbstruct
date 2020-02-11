using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    class Rectangle:TwoDShap
    {
        // Constructor for Rectangle.
        public Rectangle(double w, double h) :
        base(w, h, "rectangle")
        { }
        // Construct a square.
        public Rectangle(double x) :
        base(x, "rectangle")
        { }
        // Construct a copy of a Rectangle object.
        public Rectangle(Rectangle ob) : base(ob) { }
        // Return true if the rectangle is square.
        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }
        // Override Area() for Rectangle.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
