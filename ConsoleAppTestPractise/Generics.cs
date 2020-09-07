using System;
using System.Collections;
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



        //BitArray
        public static void PrintBar(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
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


            /*Lists and BitArray
             * - List<T> - A list is similar to an array, but the elements in a list can be inserted and removed dynamically.
             * C# generic collection List<T> class requires all elements be of the same type T.
             * 
             * List<T> properties and methods include:
             * - Count : A property that gets the number of elements contained in the list
             * - Item[int i] : Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only
             *   need to use the brackets[] and the index value inside the brackets.
             * - Add(T t) : Adds an element t to the end of the list.
             * - RemoveAt(int index) : Removes the element at the specified position (index) from the list.
             * - Sort() : Sorts elements in the list
             * See few examples of List<T> below
             */
            List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.Remove(1); //removes 72

            Console.Write("\nList: ");
            for (int xi = 0; xi < li.Count; xi++)
                Console.Write(li[xi] + " "); //59, 95, 5, 9
            li.Sort();
            Console.Write("\nSorted: ");
            for (int xi = 0; xi < li.Count; xi++)
                Console.Write(li[xi] + " "); // 5 9 59 95
            /*Additional List<T> properties and methods are listed below. Try them out by adding them to the List<T> example code above.
             * - Capacity : A property that gets the number of elements the list can hold before needing to be resized
             * - Clear() : Removes all the elements from the list
             * - TrimExcess() : Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead.
             * - AddRange(IEnumerable coll) : Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable
             *   is the collections interface that supports simple iteration over the collection.
             * - Insert(int i, T t) : inserts an element t at a specific index i in the list
             * - InsertRange(int i, IEnumerable coll) : Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections
             *   interface that supports simple iteration over the collection.
             * - Remove(T t) : Removes the first occurence of the object t from the list.
             * - RemoveRange(int i, int count) : Removes a specified number of elements count from the list starting at a specified index i.
             * - Contains(T t) : Returns true if the specified element t is present in the list
             * - IndexOf(T t) : Returns the index of the first occurrence of the element t in the list.
             * - Reverse() : Reverses the order of the elements in the list
             * - ToArray() : Copies the elements of the list into a new array
             * 
             */

            /*SortedList<k,V>
             * A sorted list is a collection of key/value pairs that are sorted by key. A key can be used to access its corresponding value in the sorted list
             * C# generic collection SortedList<K, V> class requires all element key/value pairs to be of the same type K, V. Duplicate keys are not permitted, 
             * which ensures that every key/value pair is unique.
             * 
             * SortedList<k, V> properties include:
             * - Count : Gets the number of key/value pairs contained in the sorted list
             * - Item[K key] : Gets or sets the value associated with the specified key contained in the sorted list. Item is the indexer and is not required 
             *   when accessing an element. You only need to use the brackets[] and the key, value.
             * - key : Gets a sorted and indexed collection containing only the keys in the sorted list
             * 
             * SortedList<K, V> methods include:
             * - Add(K key, V value) : Adds an element with a specific key, value pair into the sorted list.
             * - Remove(K key) : Removes the element with the specific key, value pair associated with the specified key from the sorted list.
             * example os SortedList below
             */
            SortedList<string, int> s1 = new SortedList<string, int>();
            s1.Add("Stanley", 59);
            s1.Add("the", 95);
            s1.Add("Ikechukwu", 72);
            s1.Remove("the");
            Console.WriteLine("Sorted List: ");
            foreach (string s in s1.Keys)
                Console.WriteLine(s + ": " + s1[s]); //Ikechukwu: 72 Stanley: 59
            Console.WriteLine("\nCount: " + s1.Count); //Count: 2
            /*Here are additional SortedList<K, V> properties and methods:
             * - Values : Gets a sorted and indexed collection of the values in the sorted list
             * - Clear() : removes all the elements from the sorted list
             * - ContainsKey(K key) : Returns true when the specified key is present in the sorted list
             * - IndexOfKey(K key) : Returns the index of the specified key within the sorted list
             * - IndexOfValue(V value) : Returns the index of the specified value within the sorted list
             */

            /*BitArray
             * A bit array is a collection of bits. The value of a bit can be either 0 (off/false) or 1 (on/true).
             * Bit array compactly store bits. Most commonly, they are used to represent a simple group of boolean flags or an ordered sequence of boolean 
             * values.
             * BitArray Properties includes:
             * - Count : Gets the number of bits in the bit array
             * - IsReadOnly : Gets a value indicating if the bit array is read only or not
             * 
             * BitArray methods include:
             * - Get(int i) : Gets the value of the bit at a specified position i in the bit array.
             * - Set(int i, bool value) : Sets the bit at a specified position i to a specified value in the bit array
             * - SetAll(bool value) : Sets all the bits to a specified value in the bit array.
             * - And(BitArray ba) : Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba.
             * - Or(BitArray ba) : Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba
             * - Not() : Inverts the bit values of the bit array.
             * - Xor(BitArray ba) : Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba
             * see examples on properties and methods of bitArray class below and line (42)
             */
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(2, false);
            ba2.Set(3, true);

            PrintBar("ba1", ba1);
            PrintBar("ba2", ba2);
            Console.WriteLine();

            PrintBar("ba1 AND ba2", ba1.And(ba2));
            PrintBar(" Not ba2", ba2.Not());
            /*one use case of BitArrays is in image processing to store the individual bits of a gray-scale image
             * 
             */












        }
    }
}
