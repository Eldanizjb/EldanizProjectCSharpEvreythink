using System;

namespace Access_Specifiers_____Public___
{
    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // Accepting value in public variable that is outside the class => Sınıf xaricində olan ictimai dəyişkən dəyər qəbul etmək
            ac.name = Console.ReadLine();
            ac.print();

            Console.ReadLine();
        }
    }
}
