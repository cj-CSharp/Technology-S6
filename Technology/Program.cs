using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Laptop newLaptop = new Laptop("Window's 10", 1000, false, false, 10);
            Laptop newLaptop2 = new Laptop("Window's 10", 1000, true, true, 5) ;
            SmartPhone newSmartPhone = new SmartPhone("IOS 14", 64, true, false, 5.5);

            Console.WriteLine(newLaptop.Id);
            Console.WriteLine(newLaptop2.Id);
            Console.WriteLine(newSmartPhone.Id);

        }
    }
}
