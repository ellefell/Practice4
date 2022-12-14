using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Practice 3.");

            Director director = new Director();
            director.CreateEvents();
            director.DisplayEvents();
        }
    }
}
