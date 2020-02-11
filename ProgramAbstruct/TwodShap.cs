using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAbstruct
{
    abstract class TwoDShap
    {
        double pre_width;
        double pre_height;

        // Properties for Width and Height.
        public double Width
        {
            get { return pre_width; }
            set { pre_width = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return pre_height; }
            set { pre_height = value < 0 ? -value : value; }
        }
        public string name { get; set; }
        // A default constructor.
        public TwoDShap()
        {
            Width = Height = 0;
            name = "null";
        }
        // Parameterized constructor.
        public TwoDShap(double w, double h, string n) {
            Width = w;
            Height = h;
            name = n;
        }
        // Construct object with equal width and height.
        public TwoDShap(double x, string n) {
            Width = Height = x;
            name = n;
        }
        // Construct a copy of a TwoDShape object.
        public TwoDShap(TwoDShap obj)
        {
            Width = obj.Width;
            Height = obj.Height;
        }
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            Width + " and " + Height);
        }
        // Now, Area() is abstract.
        public abstract double Area();
    }


   
}
