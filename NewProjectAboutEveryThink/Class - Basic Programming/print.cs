using System;
using System.Collections.Generic;
using System.Text;

namespace Class___Basic_Programming
{
    class print // Creating 2nd class
    {
        public void printdetails()
        {
            //Creating object of 1st. class
            accept a = new accept();
            //executing method of 1st class.
            a.acceptdetails();
            //Printing value of name variable
            Console.WriteLine("e;Your name is " + a.name);
        }

    }
}


