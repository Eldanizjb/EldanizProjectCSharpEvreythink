using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Specifiers_____Private__
{
    class access
    {
        // String Variable declared as private => String Dəyişən şəxsi olaraq elan edildi
        private string name;
        public void print() // public method => ictimai üsul
        {
            Console.WriteLine("\nMy name is " + name);
        }

    }
}
