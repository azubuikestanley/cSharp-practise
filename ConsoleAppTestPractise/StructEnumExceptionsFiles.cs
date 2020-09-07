using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPractise
{
    class StructEnumExceptionsFiles
    {

        //struct Book
        struct Book
        {
            public string title;
            public double price;
            public string author;
        }
        //struct with constructors that takes parameter
        struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        //Enum
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        enum TrafficLights { Green, Red, Yellow };

        static void Main(string[] args)
        {
            /*Struct
             * A struck type is a value type that is typically used to encapsulate small groups of related variables, such as the coordinates 
             * of a rectangle or the characteristics of an item in an inventory. The following example shows a simple struct declaration. example line(13)
             * Structs share most of the same syntax as classes, but are more limited than classes. Unlike classes, structs can be instantiated without
             * using a new operator as seen below
             */
            Book b;
            b.title = "Test";
            b.price = 5.77;
            b.author = "Stanley";
            /*Struct do not support inheritance and cannot contain virtual methods
             * Struct can contain methods, properties, indexers, and so on. Structs cannot contain default constructors (a constructor without parameters),
             * but they can have constructors that take parameters. In that case the new keyword is used to instantiate a struct object, as similar to class
             * objects.
             * for example line (20)
             */
            Point p = new Point(11, 15);
            Console.WriteLine(p.x); //output 11
            /*Struct vs Classes
             * In general, classes are used to model more complex behavior, or data, that is intended to be modified after a class object is created.
             * Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is 
             * created. Consider defining a struct instead of a class if you are trying to represent a simple set of data.
             * All standard C# types (int, double, bool, char, etc) are actually structs
             */


            /*Enums
             * The enum keyword is used to declare an enumeration: A type that consists of a set of named constants called the enumerator list. By
             * default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
             * For example, in the following enumeration, Sun is 0, Mon is 1, Tue is 2, and so on
             * enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat};
             * you can also assign your own enumerator values as below
             * enum Days {Sun, Mon, Tue=4, Wed, Thu, Fri, Sat};
             * In the example above, the enumeration will start from 0, then Mon is 1, Tue is 4, Wed is 5 and so on.
             * The value of the next item in an Enum is one increment of the previous value. Note that the values are comma separated. You can refer to 
             * the values in the Enum with the dot syntax.
             * In order to assign Enum values to int variables, you have to specify the type in parentheses
             * see example line(33)
             */
            int x = (int)Days.Wed;
            Console.WriteLine(x); //output 3
            /*Basically, Enums define varibales that represent members of a fixed set. Some sample Enum uses include month names, days of the week,
             * cards in a deck etc
             * 
             * Enums are often used with switch statements.
             * see example line (35)
             */
            TrafficLights tl = TrafficLights.Red;
            switch (tl)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go!!!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!!!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!!!");
                    break;
            }


            /*
             * 
             * 
             */



        }
    }
}
