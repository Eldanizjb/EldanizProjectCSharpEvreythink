using System;

namespace Block_Statement____
{
    #region C# Block Statement    {}      
    ////Begin Statement
    //    class Program
    //    { // Begin Statement    
    //        static void Main(string[] args)
    //        { //Begin Statement
    //            int num1, power;
    //            num1 = 5;
    //            power = num1 * num1;
    //            Console.WriteLine(power);
    //            Console.ReadLine();
    //        } // End Statement
    //    } // End Statement
    // // End Statement
    #endregion

    #region C# Empty Statement       ;            
    // class Program
    //    {
    //        public bool print()
    //        {
    //            Console.WriteLine("Steven Clark");
    //            return true;
    //        }
    //        static void Main(string[] args)
    //        {
    //            int i = 0;
    //            Program p = new Program();
    //            while (p.print())
    //            {
    //                ; //Empty Statement
    //            }
    //            Console.WriteLine("i = {0}", i);
    //            Console.ReadLine();
    //        }
    //    }

    #endregion

    #region   C# Goto Statement     goto to where we choose
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            string name;

    //        label: //creating label with colon(:)

    //            Console.WriteLine("Enter your name: ");
    //            name = Console.ReadLine();

    //            Console.WriteLine("Welcome {0}", name);
    //            Console.WriteLine("Press Ctrl + C for Exit\n");

    //            goto label; //jump to label statement           
    //        }
    //    }
    #endregion

    #region C# Break Statement      take break get out from object
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 0;

    //        while (i < 100)
    //        {
    //            Console.WriteLine(i);
    //            if (i == 20)
    //            {
    //                Console.WriteLine("breaking the current segment...");
    //                break;
    //            }
    //            i++;
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Continue Statement   
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 0;
    //        while (i < 10)
    //        {
    //            i++;
    //            if (i < 6)
    //            {
    //                continue;
    //            }
    //            Console.WriteLine(i);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Return Statement
    //class Program
    //{
    //    public int add(int num1, int num2)
    //    {
    //        // returns the add of num1 and num2
    //        return num1 + num2;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        int result;
    //        // calling the function add that will return 9 to the result vaiable.
    //        result = p.add(3, 6);
    //        Console.WriteLine(result);

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Throw Statement
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num1, num2, result;

    //        Console.WriteLine("Enter First Number");
    //        num1 = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Enter Second Number");
    //        num2 = Convert.ToInt32(Console.ReadLine());

    //        try
    //        {
    //            if (num2 == 0)
    //            {
    //                throw new Exception("Can't Divide by Zero Exception\n\n");
    //            }
    //            result = num1 / num2;
    //            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("e;Error : "e; +e.ToString());
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Checked Statement
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num;
    //        // assign maximum value
    //        num = int.MaxValue;
    //        try
    //        {
    //            checked
    //            {
    //                // forces stack overflow exception
    //                num = num + 1;
    //                Console.WriteLine(num);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.ToString());
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Unchecked Statement
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num;
    //        // assign maximum value
    //        num = int.MaxValue;
    //        try
    //        {
    //            unchecked
    //            {
    //                // forces stack overflow exception
    //                num = num + 1;
    //                Console.WriteLine(num);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.ToString());
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Lock Statement
    //class Program
    //{
    //    public void printname()
    //    {
    //        Console.WriteLine("My name is Steven Clark");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        // creating lock segment. all the resources that is used in lock segment, can't be used by another thread until it releases.
    //        lock (p)
    //        {
    //            p.printname();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    #endregion

    #region C# Using Statement
    //class check_using : IDisposable
    //{
    //    public void Dispose()
    //    {
    //        Console.WriteLine("Execute  Second");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        using (check_using c = new check_using())
    //        {
    //            Console.WriteLine("Executes First");
    //        }
    //        Console.WriteLine("Execute Third");
    //        Console.ReadLine();
    //    }
    //}

    #endregion
}