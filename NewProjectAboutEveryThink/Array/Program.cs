using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declare_Array
            //int[] num = new int[6]; //Declaring Array => Bəyan edir

            ////Initializing array => Başlanğıc
            //num[0] = 6;
            //num[1] = 23;
            //num[2] = 12;
            //num[3] = 9;
            //num[4] = 14;
            //num[5] = 52;

            ////Showing value of Array
            //Console.WriteLine("1st value:\t{0}", num[0]);
            //Console.WriteLine("2nd value:\t{0}", num[1]);
            //Console.WriteLine("3rd value:\t{0}", num[2]);
            //Console.WriteLine("4th value:\t{0}", num[3]);
            //Console.WriteLine("5th value:\t{0}", num[4]);
            //Console.WriteLine("6th value:\t{0}", num[5]);

            //Console.ReadLine();
            #endregion

            #region Storing Value In Array
            //int i;
            //int[] arr = new int[5]; // 5 size array

            //// Accepting value from user => İstifadəçidən dəyər qəbul etmək
            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("\nEnter your number:\t");
            //    //Storing value in an array
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\n\n");
            ////Printing the value on console
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("you entered {0}", arr[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region accessing_array_value
            //int[] age = new int[6];
            //string[] name = new string[6];
            //int i, j = 0;
            //string find;

            //// Storing users name and age in two different array.  => İstifadəçilərin adını və yaşını iki fərqli şəkildə saxlamaq
            //for (i = 0; i < 6; i++)
            //{
            //    Console.Write("\n\nEnter your name:\t");
            //    name[i] = Console.ReadLine();
            //    Console.Write("Enter your age:\t\t");
            //    age[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////Accepting name and find their correspondence age in array. => Adı qəbul edin və yazışma yaşını tapın

            //Console.Write("\n\nEnter your name to find age:\t");
            //find = Console.ReadLine();

            //for (i = 0; i < 6; i++)
            //{
            //    if (name[i] == find)
            //    {
            //        Console.WriteLine("\n\nName\t:{0}", name[i]);
            //        Console.WriteLine("Age\t:{0}", age[i]);
            //        j++;
            //    }
            //}
            //if (j == 0)
            //{
            //    Console.WriteLine("Not Found!!!");
            //}
            //Console.ReadLine();

            #endregion

            #region One_Dimensional_Array
            ////Declaring single dimensional array => Tək ölçülü elan
            //string[] Books = new string[5];
            //Books[0] = "C#";
            //Books[1] = "Java";
            //Books[2] = "VB.NET";
            //Books[3] = "C++";
            //Books[4] = "C";

            //Console.WriteLine("All the element of Books array is:\n\n");

            //int i = 0;
            ////Formatting Output
            //Console.Write("\t1\t2\t3\t4\t5\n\n\t");
            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}\t", Books[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region Multi Dimensional Array
            //int i, j;
            ////Declaring multi dimensional array => Çoxölçülü elan
            //string[,] Books = new string[3, 3];
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.Write("\nEnter Book Name for {0}. Row and {1}. column:\t", i + 1, j + 1);
            //        Books[i, j] = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("\n\n=========================");
            //Console.WriteLine("All the element of Books array is:\n\n");

            ////Formatting Output
            //Console.Write("\t1\t2\t3\n\n");
            ////outer loop for accessing rows
            //for (i = 0; i < 3; i++)
            //{
            //    Console.Write("{0}.\t", i + 1);

            //    //inner or nested loop for accessing column of each row => hər sətrin sütununa daxil olmaq üçün daxili və ya iç içə döngə
            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0}\t", Books[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("\n\n=========================");
            //Console.ReadLine();
            #endregion



        }
    }
    }
