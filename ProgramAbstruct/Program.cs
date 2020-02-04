using System;

namespace ProgramAbstruct
{
    public abstract class GeeksForGeeks
    {
        abstract public void gfg();
    }

    public class Geeks1 : GeeksForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("Gees 1 clsaa");
        }
    }

    public class Geeks2 : GeeksForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("Gees 2 clsaa");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GeeksForGeeks g;
            g = new Geeks1();
            g.gfg();
            g = new Geeks2();
            g.gfg();
        }
    }
}
