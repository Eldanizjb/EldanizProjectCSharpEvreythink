using System;

namespace Access_Specifiers_____Internal___
{
    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // Accepting value in protected internal variable => Qorunan daxili dəyişəndə dəyər qəbul etmək
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}
