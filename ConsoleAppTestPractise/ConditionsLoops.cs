using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestPractise
{
    class ConditionsLoops
    {
        static void Main(string[] args)
        {
            //if statement - execute a block of code is condition is true
            int x = 12;
            int y = 7;
            
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            /* when only one line of code is in the if block, the curly braces can be omitted
             eg -   */
            if (y < x)
             Console.WriteLine("X is greater than y");
           


            //Relational Opearator
            /*operators
             >=  - greater than or equal to
             <=  - less than or equal to
             ==  - equal to
             !=  - not equal to*/


            //else statement - execute a block of code if the if condition is false
            int mark = 70;

            if (mark < 60)
            {
                Console.WriteLine("below pass mark");
            }
            else
            {
                Console.WriteLine("Excellent mark");
            }

            //Nested if statement, else statement must always have an if statement 
            int fullScore = 100;

            if (fullScore >= 60)
            {
                Console.WriteLine("you passed");
                if (fullScore == 100)
                {
                    Console.WriteLine("Perfect score");
                }
            }
            else
            {
                Console.WriteLine("Below pass mark");
            }


            //we can have unlimited number of if-else statements
            int age = 17;
            if(age > 12)
            {
                if(age > 18)
                {
                    Console.WriteLine("Adult");
                } else
                {
                    Console.WriteLine("Teenager");
                }
            } else
            {
                if (age > 0)
                {
                    Console.WriteLine("Child");
                } else
                {
                    Console.WriteLine("Something's wrong");
                }
            }

            //the if-else if Statement
            //if statement can have zero or more else if and itmust come before the last else which is optional
            int k = 44;
            if(k == 7)
            {
                Console.WriteLine("Value of k is 7");
            }
            else if (k == 19)
            {
                Console.WriteLine("Value of k is 19");
            }
            else if (k == 44)
            {
                Console.WriteLine("Value of k is 44");
            }
            else
            {
                Console.WriteLine("No match");
            }


            //The Switch Statement
            int num = 4;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                default:
                    Console.WriteLine("This is the default age");
                    break;
            }
            //default code executes when none of the case matches the switch expression
            //the break statement is use to terminate the switch statement


            //The while loop



        }
    }
}
