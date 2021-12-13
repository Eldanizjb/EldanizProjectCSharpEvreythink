using System;

namespace Method_Declaration
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Methods type 
            //use Console.WriteLine Don't return anythik
            //< Access Specifier > < Return Type > < Method Name > (Parameter list)
            //    {
            //        Body
            //    }
            //
            //                               
            //public void add()   1
            //{
            //    Body
            // }
            //                       INTEGER VALUE
            //public int add()
            //{
            //    Body
            //return integer value
            //}
            //public string printname() 2
            //{
            //    Body
            // return string value
            // }
            #endregion

            #region Declaring_Method
            string name, city;
            int age;

            // Creating method for accepting details
            #region creating with monitor
            public void acceptdetails()
            {
                Console.Write("\nEnter your name:\t");
                name = Console.ReadLine();

                Console.Write("\nEnter Your City:\t");
                city = Console.ReadLine();

                Console.Write("\nEnter your age:\t\t");
                age = Convert.ToInt32(Console.ReadLine());
            }
            #endregion
            #region creating with into Visual Code Studio
            //Creating method for printing details
            public void printdetails()
                {
                    Console.Write("\n\n===================");
                    Console.Write("\nName:\t" + name);
                    Console.Write("\nCity:\t" + city);
                    Console.Write("\nAge:\t" + age);
                    Console.Write("\n===================\n");
                }
            #endregion
            static void Main(string[] args)
            {
                Program p = new Program();
                p.acceptdetails();
                p.printdetails();
                Console.ReadLine();
            }
            #endregion
        }
    }
}
