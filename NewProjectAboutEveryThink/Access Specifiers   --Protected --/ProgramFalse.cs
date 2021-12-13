using System;

namespace Access_Specifiers_____Protected___
{
    class ProgramFalse
    {
        static void Main(string[] args)
        {
            accessFalse ac = new accessFalse();
            Console.Write("Enter your name:\t");
            // raise error because of its protection level => qoruma səviyyəsinə görə səhvləri artırın
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();


            //'Protected_Specifier.access.name' is inaccessible due to its protection level.
            //This is because; the protected member can only be accessed within its child class. You can use protected access specifiers as follow: __
            //'Protected_Specifier.access.name 'qorunma səviyyəsinə görə əlçatmazdır.
            // Bunun səbəbi; qorunan üzvə yalnız uşaq sinfi daxilində daxil olmaq mümkündür. Qorunan giriş spesifikatorlarından aşağıdakı kimi istifadə edə bilərsiniz: __
        }
    }
}
