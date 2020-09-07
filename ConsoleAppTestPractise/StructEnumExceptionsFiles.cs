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
             * 
             * 
             */


        }
    }
}
