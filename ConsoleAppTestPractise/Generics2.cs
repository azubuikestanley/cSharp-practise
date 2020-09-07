using System;
using System.Collections.Generic;
using System.Text;

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
                Console.Write(i + " ");



        }
    }
}
