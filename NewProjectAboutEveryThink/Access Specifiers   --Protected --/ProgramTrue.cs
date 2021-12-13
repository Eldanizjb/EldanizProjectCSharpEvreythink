using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Specifiers_____Protected___
{
    class ProgramTrue : accessTrue // Inherit access class => Giriş sinifini miras alın
    { 
        static void Main(string[] args)
        {
            ProgramTrue p = new ProgramTrue();
            Console.Write("Enter your name:\t");
            p.name = Console.ReadLine(); // No Error!!
            p.print();
            Console.ReadLine();
        }


    }
}
