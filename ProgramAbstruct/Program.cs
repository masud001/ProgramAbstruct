using System;

namespace ProgramAbstruct
{


    class Tropozoid : TwoDShap
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
            return ((Width * Width) / 2) * Height;
        }
    }
    //------------------------------------------------------------------
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
        public TwoDShap(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }
        // Construct object with equal width and height.
        public TwoDShap(double x, string n)
        {
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
    //-------------------------------------------------------------------

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

    //--------------------------------------------------------------------------
    class Rectangle : TwoDShap
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
    //------------------------------------------------------------

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Account!");
            TwoDShap[] shapes = new TwoDShap[4];
            shapes[0] = new Triangle("right", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("object is " + shapes[i].name);
                Console.WriteLine("Area is " + shapes[i].Area());
                Console.WriteLine();
            }
        }
    }
}
/*

    INHERITENCE
Bank Account Write a console program in C# program that can perform the 
basic banking operations such as withdrawal, deposit, checking balance, etc on bank accounts. 
There are two types of bank account. Savings account provides interest to the customer 
which is added to balance at the rate of 10%. 
Whereas Current account does not provide any interest 
but a current account must have minimum balance of 100000 Taka.
     
*/
