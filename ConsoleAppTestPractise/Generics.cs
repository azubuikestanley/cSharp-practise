using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPractise
{
    class Generics
    {
        //generic method
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //Generic class - Stack
        class Stack<T>
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item)
            {
                innerArray[index++] = item;
            }
            public T Pop()
            {
                return innerArray[--index];
            }
            public T Get(int k)
            {
                return innerArray[k];
            }
        }



        static void Main(string[] args)
        {
            /* Generics - allows the reuse of code across different types.
             * For example, let's declare a method that swaps the values of its two parameters
            
            static void Swap(ref int a, ref int b)
             {
                int temp = a;
                a = b;
                b = temp;
             }
              
             Our Swap method will work only for integer parameter. If we want to use it for other types, for example, doubles or strings, 
             * we have to overload it for all the types we want to use it with. Beside a lot of code repetition, it becomes harder to 
             * manage the code because changes in one method mean changes to all of the overloaded methods.
             * Generics provide a flexible mechanism to define a generic type.
             * example line(12)
             
             static void Swap<T>(ref T a, ref T b)
             {
                T temp = a;
                a = b;
                b = temp;
             }
              
             In the above code, T is the name of our generic type, We can name it anything we want, but T is a commonly used name. Our Swap method
             * now takes two parameters of type T. We also use the T type for our temp variable that is used to swap the values.
             * 
             * Note the brackets in the syntax <T>, which re used to define a generic type.
             * We can now use our Swap method with different types, as in below and line(12)
             */
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b); //output 9 4

            string x = "Hello";
            string y = "World!";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y); //output  World Hello
            /*When calling a generic method, we need to specify the type it will work with by using brackets. So when Swap<int> is called, the T type
             * is replaced by int. For Swap<string>, T is replace by string.
             * If you omit specifying the type when calling a generic method, the compiler will use the type based on the arguments passed to the method
             * 
             * Mulitiple generic parameters can be used with a single method.
             * For example: Func<T, U> takes two different generic types.
             */



            /* Generic Classes - 
             * generic types can also be used with classes. The most common use for generic classes is with collections of items, where operations such as 
             * adding and removing items from the collection are performed in basically the same way regardless of the type of data being stored. 
             *  One type of collection is called a stack. Items are "pushed", or added to the collection, and "popped", or removed from the collection.
             *  A stack is sometimes called a Last in First Out(LIFO) data structure.
             * for example - line(20)
             * 
             * The generic class stores elements in an array. As you can see, the generic type T is used as the type of the array, the parameter
             * type for the Push method, and the return type for the Pop and Get methods.
             * Now we can create objects of our generic class as below
             */
            Stack<int> IntStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            //Stack<Person> PersonStack = new Stack<Person>()
            /*We can also use the generic class with custom types, such as the custom defined Person type.
             * In a generic class we do not need to define the generic type for its methods, because the generic type is already defined on the class level.
             * Generic class methods are called the same as for any other object.
             */
            Stack<int> intStack2 = new Stack<int>();
            intStack2.Push(3);
            intStack2.Push(6);
            intStack2.Push(7);
            Console.WriteLine(intStack2.Get(1));



            /*C# Collections
             * A collection is used to group related objects. Unlike an array, it is dynamic and can also group objects. A collection can grow
             * and shrink to accommodate any number of objects. Collection classes are organized into namespaces and contain built in methods for
             * processing elements within the collection.
             * A collection organizes related data in a computer so that it can be used efficiently. 
             * Different kinds of collections are suited to different kinds of applications and some are highly specialized to specific tasks. 
             * For example, 
             * Dictionaries are used to represent connections on social websites (such as Twitter, Facebook), 
             * Queues can be used to create task schedulers, 
             * HashSets are used in searching algorithms, etc
             * 
             * A collection typically includes methods to add, remove and count objects. 
             * The for statement and foreach statement are used to iterate through collections. Since a collection is a class you must first declare an 
             * instance of the class before you can add elements to that collection.
             * For example as below
             * List<int> li = new List<int>();
             * 
             * Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink
             * dynamically as the needs of the application change
             * 
             * 
             * Generic Collections
             * Generic collections are the preferred type to use as long as every element in the collection is of the same data type. Only desired data types can
             * can be added to a generic collection and this is enforced by using strong typing which reduces the possibility of errors.
             * The .NET framework provides a number of generic collection classes, useful for storing and manipulating data.
             * The System.Collections.Generic namespace includes the following generic collections:
             * - List<T>
             * - Dictionary<TKey, TValue>
             * - SortedList<TKey, TValue>
             * - Stack<T>
             * - Queue<T>
             * - Hashset<T>
             * 
             * To access a generic collection in your code, you will need to include the statement: using System.Collections.Generic;
             * 
             * 
             * Non-Generic Collections - 
             * Non-generic collections can store items that are of type Object. Since an Object data type can refer to any data type, 
             * you run the risk of unexpected outcomes. Non-generic collections may also be slower to access as well as execute.
             * The System.Collections namespace includes the following non-generic collections:
             * - ArrayList
             * - SortedList
             * - Stack
             * - Queue
             * - Hashtable
             * - BitArray
             * 
             * Because non-generic collections are error prone and less performant, it is recommended to always use generic collections from the
             * System.Collections.Generic namespace if available and to avoid using legacy collections from the System.Collections namespace
             * 
             */




        }
    }
}
