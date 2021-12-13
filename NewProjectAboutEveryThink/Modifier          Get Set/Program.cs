using System;

namespace Modifier__________Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // Accepting value via Name property
            ac.Name = Console.ReadLine();
            ac.print();
            Console.ReadLine();

        }
    }
}
