using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPractise
{
    class Generics2
    { 

        static void Main(string[] args)
        {

            /*Stack and Queue
             * Stack<T> is a Last In, First Out (LIFO) collection of elements where the last element that goes into the stack will be the first element that comes out
             * Inserting an element obto a stack is called pushing. Deleting an element from a stack is called popping. Pushing and popping can be performed only at 
             * the top of the stack
             * Stack can be used to create an undo-redo fucntionalities, parsing expressions (infix to postfix/prefix conversion), and much more.
             * The C# generic collection Stack<T> class requires all elements to be of the same type T.
             * 
             * Stack<T> properties includes:
             * - Count : Returns the number of elements in the stack
             * 
             * Stack<T> methods includes:
             * - Peek() : Returns the element at the top of the stack without removing it.
             * - Pop() : Returns the element at the top of the stack and removes it from the stack
             * - Push(T t) : Inserts an element t at the top of the stack.
             * Lets see an example on Stack<T>
             */
            Stack<int> s = new Stack<int>();
            s.Push(59);
            s.Push(72);
            s.Push(65);

            Console.Write("Stack: ");
            foreach (int i in s)
                Console.Write(i + " "); //65 72 59
            Console.Write("\nCount: " + s.Count); // 3
            Console.Write("\nTop: " + s.Peek()); // 65
            Console.Write("\nPop: " + s.Pop()); // 65

            Console.Write("\nStack: ");
            foreach (int i in s)
                Console.Write(i + " "); // 72 59
            Console.Write("\nCount: " + s.Count); //2
            /*Here are additional Stack<T> methods:
             * - Clear() : Removes all the elements from the stack
             * - Contains(T t) : Returns true when the element t is present in the stack
             * - ToArray() : Copies the stack into a new array
             * 
             */


            /*Queue<T>
             * A queue is a first in, first out (FIFO) collection of elements where the first element that goes into a queue is also the first element that comes out.
             * Inserting an element into a queue is referred to as Enqueue. Deleting an element from a queue is referred to as Dequeue.
             * Queues are used whenever we need to manage objects in order starting with the first one in.
             * Scenarios include printing documents on a printer, call center systems answering people on hold people, and so on.
             * 
             * The C# generic collection Queue<T> class requires that all elements be of the same type T.
             * Queue<T> properties include:
             * - Count : Gets the number of elements in the queue
             * 
             * Queue<T> methods includes:
             * Dequeue() - Returns the object at the beginning of the queue and also removes it.
             * Enqueue(T t) - Adds the object t to the end of the queue.
             * Some example of Queue<T> is below
             */
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " "); //5 10 15
            Console.Write("\nCount: " + q.Dequeue());  // 5

            Console.Write("\nQuene: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10 15
            Console.Write("\nCount: " + q.Count); //2
            /*Below are additional Queue<T> methods:
             * - Clear() : Removes all objects from the queue.
             * - Contains(T t) : Returns true when the element t is present in the queue.
             * - Peek() : Returns the object at the beginning of the queue without removing it.
             * - ToArray() : Copies the queue into a new array
             * 
             */



            /*Dictionary and HashSet
             * Dictionary<U,V>
             * A dictionary is a collection of unique key/value pairs where a key is used to access the corresponding value. Dictionaries are used in 
             * database indexing, cache implementations, and so on.
             * The C# generic collection Dictionary<K,V> class requires all key/value pairs be of the same type K,V. 
             * Duplicate keys are not permitted to ensure that every key/value pair is unique.
             * 
             * Dictionary<K,V> properties include:
             * - Count : Gets the number of key/value pairs contained in the dictionary
             * - Item[K key] : Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an 
             *   element. You only need to use the brackets [] and key value.
             * - Keys : Gets an indexed collection containing only the keys contained in the dictionary.
             * 
             * Dictionary<K,V> methods include:
             * - Add(K key, V value> : Adds the key, value pair to the dictionary
             * - Remove(K key) : Removes the key/value pair related to the specified key from the dictionary
             * 
             * Some Dictionary<K,V> examples are below: 
             */
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");  //Remove key-value pair One, 1
            d.Remove("Dos");  //Remove key-value pair Dos, 2

            Console.WriteLine("Dictionary: ");
            foreach (string ds in d.Keys)
                Console.WriteLine(ds + ": " + d[ds]); //Uno: 1 Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2
            /* In the above example, the dictionary d uses strings as it's keys and integers as the values.
             * 
             * Here are the additional Dictionary<K,V> properties and methods:
             * - Values : Gets an indexed collection containing only the values in the dictionary
             * - Clear() : Removes all the key/value pairs from the dictionary
             * - ContainsKey(K key) - Returns true if the specified key is present in the dictionary
             * - ContainsValue(V value) - Returns true if the specified value is present in the dictionary
             * 
             */

            /*HashSet<T>
             * A hash set is a set of unique values where duplicates are not allowed
             * C# includes the HashSet<T> class in the generic collections namespace. All HashSet<T> elements are required to be of the same type T.
             * Hash sets are different from other collections because they are simply a set of values. They do not have index positions and elements cannot be ordered
             * 
             * The HashSet<T> class provides high performance set operations. HashSets allow fast lookup, addition and removal of items and can be used to implement
             * either dynamic sets of items or lookup tables that allow finding and item by its key (e.g, finding the phone number of a person by the last name)
             * 
             * HashSet<T> properties include:
             * - Count : Returns the number of values in the hash set
             * 
             * HashSet<T> methods includes:
             * - Add(T t) : Adds a value(t) to the hash set
             * - IsSubsetOf(ICollection c) : returns true if the hash set is a subset of the specified collection(c)
             * 
             * Lets look at an example of HashSet<T> below:
             */
            HashSet<int> hs = new HashSet<int>();
            hs.Add(5);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " "); // 5 10 15 20  *element may be in any order
            Console.Write("\nCount: " + hs.Count);  //4

            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}:" + hs2.IsSubsetOf(hs));  //True

            /*Here are additional HashSet<T> methods:
             * - Remove(T t) : Removes the value (t) from the hash set.
             * - Clear() : Removes all the elements from the hash set.
             * - Contains(T t) : Returns true when a value (t) is present in the hash set
             * - ToString() : Creates a string from the hash set.
             * - IsSupersetOf(ICollection c) : Returns true if the hash set is a superset of the specified collection
             * - UnionWith(ICollection c) : Applies set union operation on the hash set and the specified collections (c)
             * - IntersectWith(ICollection c) : Applies set intersection operation on the hash set and the specified collection (c).
             * - ExceptWith(ICollection c) : Applies set difference operation on the hash set and the specified collection (c)
             * 
             */



        }
    }
}
