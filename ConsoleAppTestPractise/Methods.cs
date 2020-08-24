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


        //check line 123 for method overload explanation here
        static void Printi(int aj)
        {
            Console.WriteLine("Value: int" + aj);
        }
        //+ operator is used to concatenate values in this case. this method accepts an integer argument only. Overloading it will
        //make it available for other types, such as double
        static void Printi(double aj)
        {
            Console.WriteLine("Value: double " + aj);
        }
        static void Printi(string label, double aj)
        {
            Console.WriteLine(label + aj);
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
                 /*- by value copies the argument's value into the method's formal parameter, here we cam make changes to the parameter
                   within the method without having any effect on the argument
                   Note that C# uses call by value to pass arguments
                   Check example below
                 */
                static void sqR(int x)
                {
                    x = x * x;
                    Console.WriteLine(x); //this return the square of x
                }
                int ai = 4;
                sqR(ai);
                Console.WriteLine(ai); // this returns the value of ai

                /*-Passing by Reference - this copies an argument's memory address into the formal parameter. inside the method, the
                                          address is used in the call, this means that changes made to the parameter affect the argument.
                                          To pass the value by reference, the ref keyword is used in both the call and the method definition
                                        */
                static void SqrR(ref int xj)
                {
                    xj = xj * xj;
                }
                int bi = 3;
                SqrR(ref bi);
                Console.WriteLine(bi); // output is 9; the ref keyword passess the memory address to the method parameter, which allows the 
                                       // method to operate on the actual variable

                /*-Passing by Output - Output parameters are similar to reference parameters, except that they transfer data out of the method
                                       rather than accept data in. they are defined using the out keyword.
                                       The variable supplied for the output parameter need not be initialized since that value will not be used. 
                                       Output parameters are particularly useful when you need to return multiple values from a method
                                    */
                static void GetValues(out int j, out int k)
                {
                    j = 5;
                    k = 42;
                }
                int d, e;
                GetValues(out d, out e); // now d equals 5 , e equals 42. 
                                         //Note that output parameters get their value from the method 
                                         //the out keyword is used both when defining the method and when calling it

            /*
             * Method Overloading
             * iswhen multiple methods have the same name but different parameters.
             * check line 22 for the example on method overload
             */
            Printi(22);
            Printi(20.45);
            /*
             * when overloading methods, the definitions of the methods must differ from each other by the types and/or number of parameter
             * when there are overloaded methods, the methods called is based on the arguments. An integer argument will call the method
             * implementation that accepts an integer parameter, A double argument will call the implementation that accepts a double parameter.
             * Multiple arguments will call the implementation that accepts the same number of arguments.
            */
            Printi("Average: ", 7.57); //multiple argument overload




        }

    }
}
