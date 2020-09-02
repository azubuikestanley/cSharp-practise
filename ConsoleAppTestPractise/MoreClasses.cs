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

        //this keyword
        class Person
        {
            private string name;
            public Person(string name)
            {
                this.name = name;
            }
        }

        class Person2
        {
            private readonly string name = "John";
            public Person2(string name)
            {
                this.name = name;
            }
        }


        class Clients
        {
            private string[] names = new string[10];

            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }


        class Box
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }
            public static Box operator+(Box a , Box b)
            {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
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
            Array.Sort(testArr);

            string st1 = "some string";
            string st2 = " another string";
            Console.WriteLine(String.Concat(st1, st2)); //combines the two string
            Console.WriteLine(String.Equals(st1, st2)); //returns false as its not equal

            Console.WriteLine(DateTime.Now); //returns the current date and time
            Console.WriteLine(DateTime.Today); //returns the current day
            Console.WriteLine(DateTime.DaysInMonth(2012, 2)); //return the number of days in the specified month
                                                              //The Console class is also an example of a static class, We use its static WriteLine() method to output to the screen, or the static ReadLine() method to get user input
                                                              //The Convert class used to convert value types is also a static class



            /* this and readonly
             * The this keyword
             * The this keyword is used inside the class and refers to the current instance of the class, meaning it refers to the current object.
             * One of the common uses of this is to distinguish class members from other data, such as local or formal parameters of a method. as shown in the 
             * example on line(82);
             * here, this.name represents the member of the class, whereas name represents the parameter of the constructor.
             * Another common use of this is for passing the current instance to a method as parameter: ShowPersonInfo(this);
             * 
             * The readonly Modifier
             * The readonly modifier prevents a member of a class from being modified after contruction. It means that the field declared as readonly can be modified
             * only when you declare it or from within a constructor.
             * example, see line(91)
             * if we try to modiify the name field anywhere else, we will get an error.
             * There are three major differences between readonly and const fields
             * 1 - A constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization, as in:
             *       readonly string name; // ok
             *       const double PI; //error
             * 2 - A readonly field value can be changed in a constructor, but a constant value cannot
             * 3 - The readonly field can be assigned a value that is a result of a calculation, but constants cannot, as in:
             *        readonly double a = Math.Sin(60); //ok
             *        const double b = Math.Sin(60); // Error!
             */




            /*Indexers  -  An indexer allows objects to be indexed like an array
             * As discussed earlier, a string variable is actually an object of the String class. Further, the String class is actually an array of Char objects.
             * In this way, the string class implements an indexer so we can access any character (Char object)  by its index
             */
            string strg = "Hello World";
            char x = strg[4];
            Console.WriteLine(x); //output o   //Arrays use integer indexes, but indexers can use any type of index such as strings, characters etc
            /*Declaration of an indexer is to some extent similar to a property. The difference is that indexer accessors require an index.
             * Like a property, you use get and set accessors for defining an indexer. However, where properties return or set a specific data member,indexers
             * return or set a particular value from the object instance.
             * Indexers are defined with the this keyword.
             * for example, see line(101)
             * As you can see, the indexer definition includes the this keyword and an index, which is used to get and set the appropriate value.
             * Now when we declare an object of class Clients, we use an index to refer to specific objects like the elements of an array
             */
            Clients c = new Clients();
            c[0] = "Stan";
            c[1] = "iyke";
            Console.WriteLine(c[0]); //output  stan
            Console.WriteLine(c[1]); //output iyke
                                     //we typically use an indexer if the class represents a list, collection, or array of objects



            /*Operator Overloading
             * More operators in C# can be overloaded, meaning they can be redefined for custom actions.
             * For example, you can redefine the action of the plus(+) operator in a custom class.
             * Consider the Box class that has Height and Width properties
             * example in line(119)
             
                Box b1 = new Box(14, 3);
                Box b2 = new Box(5, 7);
                we would like to add these two box objects, which would result in a new, bigger Box.
                So, basically, we would like the following code to work;
                Box b3 = b1 + b2;
                The height and width properties of object b3 should be equal to the sum of the properties of b1 and b2 objects.
                This is achieved through operator overloading

                Overloaded operators are methods with special names, where the keyword operator is followed by the symbol for the operator beingdefined.
                Similar to any other method, an overloaded operator has a return type and a parameter list. 
                example, line(119), for our box class, we overload the + operator
                The method (119) above defines an overloaded operator + with two Box object parameters and returning a new Box object whose Height and Width
                properties equal the sum of its parameter's corresponding properties.
                Additional, the overloaded operator must be static
            */
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;
            Console.WriteLine(b3.Height); //output 19
            Console.WriteLine(b3.Width);  //output 10
            //All arithmetic and comparison operators can be overloaded. For instance, you could define greater than and less than operators for the boxes
            //that would compare the Boxes and return a boolean result. Just keep in mind that when overloading the greater than operator, the less than 
            //operator should also be defined


        }

    }
}
