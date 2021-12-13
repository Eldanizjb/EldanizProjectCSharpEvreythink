using System;

namespace Access_Specifiers_____Private__
{
    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // raise error because of its protection level => qoruma səviyyəsinə görə səhvləri artırın
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();

            //Error 1: Private_Access_Specifiers.access.name' is inaccessible due to its protection level __
            //Xəta 1: Private_Access_Specifiers.access.name 'qorunma səviyyəsinə görə əlçatmazdır __
        }
    }
}
