using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestPractise
{
    class Methods
    {
        static void sayHi()
        {
            Console.WriteLine("Hello there");
        }
        
        //passing parameter to a method
        
        static void Print(int j)
        {
            Console.WriteLine(j);
        }
        static void Main(string[] args)
        {
            sayHi();
            Print(45);//you can pass different arguments to the same methods as long as they are of the expected type
            Print(61);

            //we can have as many parameters as needed for a method by separating them with commas
            int Sum(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine(Sum(2, 5)); //can also be done as below by assigning the return value to a variable as seen below
            int newSum = Sum(3, 5);
            Console.WriteLine(newSum);

            //optional Arguments - we can specify a default value for optional parameters, if corresponding arguments are missing 
            //                   //when the method is called, the method uses the default values
            static int Powe(int x, int y = 3)
            {
                int results = 1;
                for (int i = 0; i < y; i++)
                {
                    results *= x;
                }
                return results;
            }

            Console.WriteLine(Powe(3)); //output 27, default value of y is 3, check out example below
            Console.WriteLine(Powe(3, 2)); //output 9, optional value of y is 2

            //Name Arguments - Named arguments free us from the need to remember the order of the parameters in a method call.
                               //each argument can be specified by the matching parameter name. check example below
            static int Areas(int h, int w)
            {
                return h * w;
            }
            int ress = Areas(w: 5, h: 4);
            Console.WriteLine(ress);
        }

    }
}
