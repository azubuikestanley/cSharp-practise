using System;

namespace ConsoleAppTestPractise
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World!");

            //replacing variable with placeholder
            int x = 54;
            double y = 30;
            Console.WriteLine("x = {0}; y = {1}", x, y);

            //getting users input
            string yourName;
            Console.WriteLine("What is your name");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }
    }
}
