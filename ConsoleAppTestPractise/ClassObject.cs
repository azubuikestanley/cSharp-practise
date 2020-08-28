using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestPractise
{
    class ClassObject
    {
        //class example
        public string name;
        public int age;

        public void SayHI()
        {
            Console.WriteLine("Hi");
        }

        static void Main(string[] args)
        {
            //Classes - In object-oriented programming, a class is a data type that defines a set of variables and methods for a declared object
            //Object - an object is called an instance of a class
            /*
             * Value types - C# has two ways of storing data, 
             * by reference (stored in part of memory called the heap -reference type are used for storing object) 
             * and by value (stored in memory in a location called the stack)
             * Stack is used for static memory allocation, which includes all your value types, like x
             * Heap is used for dynamic memory allocation, which includes custom objects, that might need additional memory during the runtime of your program
             */

            /*ClassObject person1 = new ClassObject();
                person1.SayHI(); //check Method.cs file where this is called (183)
            */

            /* We can access all public members of a class using the dot operator. Beside calling amethod, you can use the dot operator
             * to make an assignment when valid.
             * For example
               class Dog 
               {
                public string name;
                public int age;
               }

                static void Main(string[] arg)
                {
                    Dog bob = new Dog();
                    bob.name = "Bobby";
                    bob.age = 3;

                   Console.WriteLine(bob.age); //output 3
                   //see Method.cs file (187) for code reference to ClassObject (10)
                }
             * 
             */
        }
    }
}
