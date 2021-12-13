using System;
using System.Collections.Generic;
using System.Text;

namespace Modifier__________Get_Set
{
    class access
    {
        // String Variable declared as private
        private static string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
        public string Name //Creating Name property
        {
            get //get method for returning value
            {
                return name;
            }
            set // set method for storing value in name field.
            {
                name = value;
            }
        }


    }
}
