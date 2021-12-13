using System;

namespace Metod_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting execution
            // Creating object of class check
            check chk = new check();
            chk.accept(); //Invoking accept method
            chk.print(); //Invoking print method
            Console.ReadLine();
        }
    }
}
