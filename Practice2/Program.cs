using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Practice 2.");

            Director director = new Director();
            director.CreateOrders();
            director.DisplayOrders();
        }
    }
}
