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
            //- this repeatedly execute a block of code as long as a given conditio is true
            int fig = 0;
            while(fig < 5)
            {
                Console.WriteLine(fig);
                fig++;
                //compound arithmetic operator can also be used here
                //fig += 2;
            }
            /*this is same as above
             * int fig = 1;
             * while(++fig < 5)
             *   Console.WriteLine(fig);
             */
            /*
             while(fig++ < 5) and while(++fig < 5) are different
             - the loop  while(++num < 5) will execute 4 times because pre-increment increases the value of fig before checking
               the fig < 5 condition, while post-increment will check the condition before increasing the value of fig, making 
               while(fig++ < 5) execute 5 times.

             */


            //The for Loop
            //this execute a set of statement a specific number of times
            /* syntax
            for (init; Condition; increment)
            {
                statement(s);
            }
            */

            for (int xy = 12; xy < 15; xy++)
            {
                Console.WriteLine("Value of xy: {0}", xy);
            }
            //we can use compound arithmetic operators to further control loop iterations
            /*
             * for(int xyz = 0; xyz < 10; xyz += 3)
             * for(int yz = 0; yz < 10; yz -= 3) 
             */
            /*the init and increment statement may be left out if not needed but the semicolons are mandatory
             int x = 10;
             for( ; x > 0; x -= 3 ){Console.WriteLine(x)}

             int x = 10;
             for( ; x > 0; ){Console.WriteLine(x); x -= 3;}

            note that code below would become an infinite loop
            for(;;) {}
             */



            //The do-while Loop
            //this is similar to while loop but it guaranteed to execute at least one time
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 5);
            //difference btw do-while loop and while loop
            /*
             * the do-while loop will execute statement at least once before testing the condition while the while loop 
             * will test the condition before executing the statement 
             */


            //Break
            //this helps terminate a loop or a switch statement. When break statement is encountered inside a loop, the loop is 
            //immediatedly terminated and the program execution moves on to the next statement following the loop
            int numOne = 2;
            while (numOne < 20)
            {
                if (numOne == 6)
                    break;

                Console.WriteLine(numOne);
                numOne++;
            }

            //Continue
            //This is similar to the break statement but instead of terminating the loop entirely, it skips the current iteration 
            //of the loop and continue with the next iteration
            for (int ik = 2; ik < 10; ik++)
            {
                if (ik == 4)
                    continue;

                Console.WriteLine(ik);
            }


            //Logical Operators
            //this is used to join multiple expressions and return true or false
            /*(Operator)            (Name of Operator)          (Form)
               &&                   AND  Operator               x && y
               ||                   OR   Operator               x || y
               !                    NOT Operator                !x
             */
            //And operator - for AND Operator to be true, both/All expressions/operands must be true
            int AgeMan = 40;
            double money = 520;
            if(AgeMan > 20 && money > 250)
                Console.WriteLine("Welcome");
            //joining more than two conditions, all expression would true only if all conditions are true
            int ageBoy = 12;
            int grade = 75;
            if (ageBoy > 7 && ageBoy < 60 && grade > 50)
                Console.WriteLine("Hey there");

            //OR operator - for OR Operator to return true, at least one expressions/operands must be true
            int ageOr = 18;
            int score = 85;
            if (age > 20 || score > 50)
                Console.WriteLine("Welcome OR");

            //Logical NOT (!) - this reserve a logical state, from true to false and vice versa
            int ageNot = 8;
            if ( !(ageNot >= 16))
            {
                Console.Write("Your age is less than 16");
            }

            //Conditional Operator, ?: Operator - this is similar to ternary operator in javascript and php
            int ageCondition = 42;
            string msg;
            if (ageCondition >= 18)
                msg = "Welcome";
            else
                msg = "Sorry";
            Console.WriteLine(msg);

            //the if statement above can be shortened like the code below using the ?: operator
            int ageCondition2 = 42;
            string msg2;
            msg2 = (ageCondition2 >= 18) ? "Welcome2" : "Sorry 2";
            Console.WriteLine(msg2);


            //-----------------------------------------------------------------------------------------------------------------------------------------
            /*
             * Calculator Project
             * -Create a simple project that repeatedly asks the user to enter two values and then displays their sum, 
             * until the user enters exit
             */
            //-using a do-while loop
            /*
             do
             {
                 Console.Write("xi = ");
                 int xi = Convert.ToInt32(Console.ReadLine());

                 Console.Write("yi = ");
                 int yi = Convert.ToInt32(Console.ReadLine());

                 int sumXiYi = xi + yi;
                 Console.WriteLine("Result: {0}", sumXiYi);
             }
             while (true);
             */
            //the do while block above will run infinitely even if the user enters 'exit' as input, so we refactor with below code
            do
            {
                Console.Write("xi = ");
                string str = Console.ReadLine();
                if (str == "exit" || str == "")
                    break;

                int xi = Convert.ToInt32(str);

                Console.Write("yi = ");
                string str2 = Console.ReadLine();
                if (str2 == "exit" || str == "")
                    break;
                int yi = Convert.ToInt32(str2);

                int sumXiYi = xi + yi;
                Console.WriteLine("Result: {0}", sumXiYi);
            }
            while (true);

        }
    }
}
