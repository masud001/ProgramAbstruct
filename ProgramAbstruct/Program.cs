using System;

namespace ProgramAbstruct
{

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
