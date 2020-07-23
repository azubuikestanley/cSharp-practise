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
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);

            //taking integer from input and display in a message
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);

            //var keyword
            /* var keyword is used by c# to enale the compiler to determine the type of the variable 
            automatically based on the expression it is assigned to   */
            /* variables decleared using the var keyword are called implicitly typed variables. 
             -implicitly typed variables must be initialized with a value. the commented code below will cause an error */
            //var num;
            //num = 16;
            //correct way should be    var num = 16;

            //constants
            /*Constacts store value that cannot be changed from their initial assignment, use const to declare a constant */
            const double PI = 3.14;
            Console.WriteLine(PI);
            //constants must be initialized with a value when declared.
            //reassignment of PI later on will cause an error, check commented code below
            //PI = 56;


            //Arithmetic operators
            /* c# support the following operators
             -addition:   +
             -subtraction:   -
             -multiplication:   *
             -division:   /
             -modulus:   %
             */
            int a = 20;
            int b = 34;
            Console.WriteLine(b - a);
            Console.WriteLine(a + b);
            Console.WriteLine(b / a);   //if both operands are integer, remainder will be dropped to return an integer
            Console.WriteLine(b % a);   //modulus operator returns the remainder after division
            /* Operator precedence  
             (multiplication, division and modulus operators will be evaluated before addition and substration operator)
             note that operator in parentheses will be executed first */

            //Assignment Operators =
            int i = 42;
            i += 2;  //i is now 44 bcos this means i = i + 2;
            i -= 4;  //i is now 40 bcos this means i = i - 2;
            i *= 2;  //equivalent to i = i * 2
            i /= 1;  //equivalent to i = i / 1
            i %= 7;  //equivalent to i = i % 1

            //Increment operator (++) - used to increase an interget value by one
            i++;  //equivalent to i = i + 1
                  //increment operator has two forms, the prefix and postfix
            ++i;  //prefix - increment the value and then proceeds with the expression
            i = 2;
            int j = ++i;    // i = 3, y = 3
  
            i++;  //postfix - evaluates the expression and then performs the incrementing
            i = 5;
            j = i++;   //i = 6, j = 5
            Console.WriteLine(i);

            //Decrement Operator (--) - works same way with increment operator but decreases instead
            --i; //prefix
            i++; //prefix


        }
    }
}
