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
            int ress = Areas(w: 5, h: 4); //output is 20
            Console.WriteLine(ress);

            /*Passing Arguments - There are three ways to pass arguments to a method when the method is called
             * by value
             * by reference
             * and as output
             */
                 //- by value copies the argument's value into the method's formal parameter, here we cam make changes to the parameter
                 //within the method without having any effect on the argument
                 //Note that C# uses call by value to pass arguments
                 //Check example below
                static void sqR(int x)
                {
                    x = x * x;
                    Console.WriteLine(x); //this return the square of x
                }
                int ai = 4;
                sqR(ai);
                Console.WriteLine(ai); // this returns the value of ai

                //-Passing by Reference - this copies an argument's memory address into the formal parameter. inside the method, the
                                        //address is used in the call, this means that changes made to the parameter affect the argument.
                                        //To pass the value by reference, the ref keyword is used in both the call and the method definition
                static void SqrR(ref int xj)
                {
                    xj = xj * xj;
                }
                int bi = 3;
                SqrR(ref bi);
                Console.WriteLine(bi);





        }

    }
}
