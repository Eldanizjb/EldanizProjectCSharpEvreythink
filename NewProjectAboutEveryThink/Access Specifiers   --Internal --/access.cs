using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Specifiers_____Internal___
{
    class access
    {
        // String Variable declared as protected internal => String Dəyişən qorunan daxili olaraq elan edildi
        protected internal string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
}
