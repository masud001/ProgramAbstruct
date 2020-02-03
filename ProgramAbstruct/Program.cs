using System;

namespace ProgramAbstruct
{
    public class gfg
    {
        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }


    public class Geegksforgeegs : gfg
    {
        public Geegksforgeegs() {
            Console.WriteLine("Geegksforgeegs");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Geegksforgeegs obj = new Geegksforgeegs();
            obj.readers("Masud", "C#");
        }
    }
}
