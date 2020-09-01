using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPractise
{
    class MoreClasses
    {
        /*
         * Destructors
         * As constructors are used when a class is instantiated, destructors are automatically invoked when an object is destroyed or deleted
         * Destructors have the following attributes:
         * - A class can only have one destructor
         * - Destructors cannot be called, they are invoked automatically
         * - A destructor does not take modifiers or have parameters.
         * -The name of a destructor is exactly the same as the class prefixed with a tilde(~).
         * eg- 
         * class Dog 
         * {
         *     ~Dog()
         *     {
         *     //code statement
         *     }
         * }
         * 
         *Note - Destructors can be very useful for releasing resources before coming out of the program. This can include closing files, releasing memory, and so on.
         
         * Let's include WriteLine statement in the destructor and constructor of our class and see how the rpogram behaves when an object of that 
         * class is created and when the program ends:
         */
         class Love
         {
            public Love()
            {
                Console.WriteLine("Constructor");
            }
            ~Love()
            {
                Console.WriteLine("Destructor");
            }
         }

        class Cat
        {
            public static int count = 0;
            public Cat()
            {
                count++;
            }
        }

        class Dog
        {
            public static void Bark()
            {
                Console.WriteLine("Woof");
            }
        }

        //Constant members are static by definition
        class MathClass
        {
            public const int ONE = 1;
        }

        //Static Constructor
        class SomeClass
        {
            public static int X { get; set; }
            public static int Y { get; set; }

            static SomeClass()
            {
                X = 20;
                Y = 45;
            }
        }


        static void Main(string[] args)
        {
            Love b = new Love();
            Console.WriteLine("main code before destructor runs");


            /*
             * Static Members
             * class members (variables, properties, methods) can also be declared as static. This makes those members belong to the class itself, instead
             * of belonging to individual objects, no matter how many object of the class are created, there is only one copy of the static member
             * eg
             * class Dog {
             *     public static int count = 0;
             *     public Dog() {
             *         count++;
             *     }
             * }
             * Here we declared a public member variable count, which is static. The constructor of the class increments the count variable by one.
             * Note that no matter how many Dog objects are instantiated, ther is always only one count variable that belongs to the cat
             * class because it was declared static
             * 
             * because of their global nature, static members can be accessed directly using the class name without an object
             * eg2 below , also, Cat Class (45)
             */

            Cat c1 = new Cat();
            Cat c2 = new Cat();

            Console.WriteLine(Cat.count); //output 2
            //we must access static members using the class name. if we try to access them via an object of that class, we will generate an error
            //eg 3 - static methods can access only static members
            Dog.Bark(); //output Woof

            //Note - The Main method is static, as it is the starting point of any program. Therefore any method called directly from Main had to be static.

            //Note - Constant members are static by definition. 
            //eg 4
            Console.WriteLine(MathClass.ONE); //output 1, remember static methods can access only static members, this shown const members are static by default since we access
                                              // the property ONE using the name of the class

            /*Static Constructor - constructors can be declared static to initialize static members of the class, the static constructor is automatically called once when
            *we access a statics member of the class.
            * */
            Console.WriteLine(SomeClass.X);
            Console.WriteLine(SomeClass.Y);


            /*
             * Static Classes - An entire class can be declared as static. A static class can contain only static members, You cannot instantiate an object of a static class
             * as only one instance of the static class can exist in a program.
             * Static classes are useful for combining logical properties and methods. A good example of this is the Math class. It contains various useful properties
             * and methods for mathematical operators. For example, the Pow method raises a number to a power:
             * 
             */
            Console.WriteLine(Math.Pow(3,2)); //output 9 i.e 3*3=9
                                              //we can access all members of the Math class using the class name, without declaring an object
            /*c# has some useful static methods and properties available , some of which are below
             * Math class - Math.PI, Math.E, Math.Max(), Math.Min(), Math.Abs(), Math.Sin(), Math.Cos(), Math.Pow(), Math.Round(), Math.Sqrt()
             * Array class - Array.Reverse(), Array.sort() 
             * String class - String.Concat(), String.Equals()
             * DateTime class - DateTime.Now, DateTime.Today, DateTime.DaysInMonth(2016, 2)
             */
            int[] testArr = { 3, 2, 5, 6, 1, 4 };
            Array.Reverse(testArr);
            Console.WriteLine(testArr);
            Array.Sort(testArr);
            Console.WriteLine(testArr);

            string st1 = "some string";
            string st2 = "another string";
            Console.WriteLine(String.Concat(st1, st2)); //combines the two string
            Console.WriteLine(String.Equals(st1, st2)); //returns false as its not equal

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.DaysInMonth(2012, 2));




        }

    }
}
