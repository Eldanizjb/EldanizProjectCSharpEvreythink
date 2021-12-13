using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic_Operators      +    -    *     /
            int num1, num2;
            int add, sub, mul;
            float div;

            //Accepting Values from users
            Console.Write("Enter first number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Processing Values
            //Used + operator for adding values
            add = num1 + num2;
            //Used - operator for subtracting values
            sub = num1 - num2;
            //Used * operator for multiplying values
            mul = num1 * num2;
            //Used / operator for dividing values
            div = (float)num1 / num2;

            //Displaying Output
            Console.WriteLine("\n\n=====================\n");
            Console.WriteLine("Addition\t\t{0}", add);
            Console.WriteLine("Subtraction\t\t{0}", sub);
            Console.WriteLine("Multiplication\t\t{0}", mul);
            Console.WriteLine("Division\t\t{0}", div);
            Console.WriteLine("\n=======================\n");

            Console.ReadLine();
            #endregion

            #region Assignment_Operator       +=   -=   *=   %=    
            //int num1, num2;

            //num1 = 10;
            //num2 = 5;

            //num1 += num2; // same as num1=num1+num2
            //Console.WriteLine("Add = {0}", num1);

            //num1 -= num2; // same as num1=num1-num2
            //Console.WriteLine("\n\nSubtraction = {0}", num1);

            //num1 *= num2; // same as num1=num1*num2
            //Console.WriteLine("\n\nMultiplication={0}", num1);

            //num1 %= num2; // same as num1=num1%num2
            //Console.WriteLine("\n\nModulus = {0}", num1);

            //Console.ReadLine();

            #endregion

            #region Comparison_Operator           >  <    
            //int num1, num2;

            ////Accepting two inputs from the user
            //Console.Write("Enter first number\t");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number\t");
            //num2 = Convert.ToInt32(Console.ReadLine());

            ////Processing comparison
            ////Check whether num1 is greater than or not
            //if (num1 > num2)
            //{
            //    Console.WriteLine("{0} is greater than {1}", num1, num2);
            //}
            ////Check whether num2 is greater than or not
            //else if (num2 > num1)
            //{
            //    Console.WriteLine("{0} is greater than {1}", num2, num1);
            //}
            //else
            //{
            //    Console.WriteLine("{0} and {1} are equal", num1, num2);
            //}
            //Console.ReadLine();

            #endregion

            #region Decrement_Operator             --
            //int i = 5; // Initialization
            //Console.WriteLine("The Value of i is {0}", i);

            //i--; // i decremented by one. It is post-decrement

            //Console.WriteLine("\nNow the value of i is {0}", i);

            //Console.ReadLine();

            #endregion

            #region Increment_Operator          ++
            //int i = 0; // initialization

            //i++; // i incremented by one. It is post increment

            //Console.WriteLine("The value of i is {0}", i);

            //Console.ReadLine();

            #endregion             ++

            #region And operator            &&
            //string name, password;

            //name = "Steven";
            //password = "Steven123";

            //// evaluating both expresson and returns true if              all are true.
            //if (name == "Steven" && password == "Steven123")
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Unauthorised access");
            //}
            //Console.ReadLine();
            #endregion

            #region Or_operator     ||
            //char ch;

            //Console.Write("Enter a character: \t");
            //ch = Convert.ToChar(Console.ReadLine());

            //if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            //{
            //    Console.WriteLine("\n\n{0} is vowel", ch);
            //}
            //else
            //{
            //    Console.WriteLine("\n\n{0} is not vowel", ch);
            //}
            //Console.ReadLine();

            #endregion

            #region Not_Operator     !
            string username, password;

            Console.Write("Enter user name:\t");
            username = Console.ReadLine();
            Console.Write("Enter Password:\t");
            password = Console.ReadLine();

            if (!(username == "Steven" && password == "demopass"))
            {
                Console.WriteLine("\nLogin Successful");
            }
            else
            {
                Console.WriteLine("\nUnauthorised Access. Aborting...");
            }
            Console.ReadLine();

            #endregion

            #region Xor Operator     ^
            //string name, password;

            //name = "Steven";
            //password = "demopass";

            ////it returns false because both expression match.
            //if ((name == "Steven") ^ (password == "demopass"))
            //{
            //    Console.WriteLine("Acess granted...");
            //}
            //else
            //{
            //    Console.WriteLine("Access Denied. Aborting...");
            //}
            //Console.ReadLine();

            #endregion





        }
    }
}
