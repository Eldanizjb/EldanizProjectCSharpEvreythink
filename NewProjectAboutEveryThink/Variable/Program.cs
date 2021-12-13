using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable
            string name;
            string city;
            sbyte age;
            int pin;
            // \n is used for line-break
            Console.WriteLine("Enter your name\n");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your City\n");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age\n");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin\n");
            pin = Int32.Parse(Console.ReadLine());

            // Printing message to console
            //formatting output
            Console.WriteLine("==============");
            Console.WriteLine("Your Complete Address:");
            Console.WriteLine("============\n");

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Pin = {0}", pin);
            Console.WriteLine("===============");

            Console.ReadLine();
            #endregion

            #region Conversion ParsInt32 or Convert.ToInt32
            //Integer = int32.parse() or Convert.ToInt32()
            //Float = (float)
            //Double = Convert.ToDouble()
            //Decimal = Convert.ToDecimal()
            //Byte = Convert.ToByte()
            ////cretaing integer type variable
            //int num1, num2, result;
            ////Displaying message
            //Console.WriteLine("Please enter first value");

            ////Accepting Value in num1
            //num1 = Int32.Parse(Console.ReadLine());
            ////Displaying message
            //Console.WriteLine("Enter second Value");
            ////Accepting Value
            //num2 = Int32.Parse(Console.ReadLine());

            //result = num1 + num2; //processing value

            //Console.WriteLine("Add of {0} and {1} is {2}", num1, num2, result); //Output

            //Console.ReadLine();
            #endregion



        }
    }
}
