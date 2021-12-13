using System;
using System.Collections.Generic;
using System.Text;

namespace Metod_Static
{
    class number
    {
        // Create static variable
        public static int num;
        //Create static method
        public static void power()
        {
            Console.WriteLine("Power of {0} = {1}", num, num * num);
            Console.ReadLine();
        }


    }
}
