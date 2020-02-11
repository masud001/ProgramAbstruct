using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    class Triangle : TwoDShap
    {
        string Style;
        public Triangle()
        {
            Style = "null";
        }
        // Constructor for Triangle.
        public Triangle(string s, double w, double h) :
        base(w, h, "triangle")
        {
            Style = s;
        }
        // Construct an isosceles triangle.
        public Triangle(double x) : base(x, "triangle")
        {
            Style = "isosceles";
        }
        // Construct a copy of a Triangle object.
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }
        // Override Area() for Triangle.
        public override double Area()
        {
            return Width * Height / 2;
        }
        // Display a triangle's style.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
}
