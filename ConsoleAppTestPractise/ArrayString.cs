using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTestPractise
{
    class ArrayString
    {
        static void Main(string[] args)
        {
            //An array is a data structure that is used to store a collection of data, you can think of it as a collection of variables of the same type 
            //we first instantiate an array to create it, eh below
            int[] myArray = new int[5];  //we then assign values to individual element by using the index number
            myArray[0] = 23;
            //we can provide initial values to the array when it is declared by using curly brackets
            string[] name = new string[3] { "John", "Mary", "Jessy" };
            double[] price = new double[3] { 2.4, 4.5, 5.6 };
            //we can omit the size declaration when the number of elements are provided in the curly braces
            string[] names = new string[] { "John", "Mary", "Jessy" };
            double[] prices = new double[] { 2.4, 4.5, 5.6 };
            //we can even omit the new operator
            string[] names2 = { "John", "Mary", "Jessy" };
            double[] prices2 = { 2.4, 4.5, 5.6 };
            //Array value should be provided in a comma separated list enclosed in {curly braces}

            //using Arrays in Loops
            int[] a = new int[10];
            for (int k = 0; k < 10; k++)
            {
                a[k] = k * 2;
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(a[k]);
            }


            //foreach Loop
            //code above can be rewritten as below with foreach loop
            int[] b = new int[10];
            for (int l = 0; l < 10; l++)
            {
                b[l] = l * 2;
            }
            foreach (int l in b)
            {
                Console.WriteLine(l);
            }
            //write a forach loop to calculate the sum of all the elements of an array
            int[] arr = { 11, 34, 54, 467, 656 };
            int sum = 0;

            foreach (int c in arr)
            {
                sum += c;
            }
            Console.WriteLine(sum);


            /*
             * Multidimensional Arrays
               A multidimensional array is declared as follows:
               type[, , ...,] arrayName = new type[size1, size2, ..., sizeN];
               The example below is a two dimensional 3x4 interger array
               int[ , ] x = new int[3,4];
               int[,] someNums = { { 2, 3 }, { 7, 5 }, { 4, 6 } };  //Array with three ows and two columns, nested curly braces are used to define values for each row.
               To access an element of an array, provide both indexes, eg , someNums[2,0] will return the value 4 as it accesses the first column of the third row. 
             */
            //Let create a program that will display the values of the array in the form of  table.
            int[,] someNums = { { 2, 3 }, { 7, 5 }, { 4, 6 } };
            for (int m = 0; m  < 3; m++)
            {
                for (int n = 0; n < 2; n++)
                {
                    Console.WriteLine(someNums[m, n] + "");
                }
                Console.WriteLine();
            }


            /*
             * Jagged Arrays
             * This is an array whose element are arrays,, basically an array of arrays.
             * example - int [][] jaggedArr = new int[3][];
             */
            int[][] jaggedArr = new int[][]
            {
                new int[] {1,8,2,7,9},
                new int[] {2,4,6},
                new int[] {33,42}
            };
            //we can access individual array element as shown below
            int jA = jaggedArr[2][1]; //42 - access second element of the third array
                                      //Note
            /*A jagged array is an array of array, so an int[][] is an array of int[], each of which can beof different lengths and occupy their own block in memory 
             *A multidimentional array (int[,]) is a single block of memory(essentially a matrix). It always has the same amount of columns for every row
             */


            /*
             * Array properties
             * The array class in C# privides provides various properties and method to work with arrays.for example, the Length and Rank property
             * return the number of elements and the number of dimensions of the array respectively.it can be access with dot syntax as seen below
             */
            int[] arry = { 3, 5, 8, 4 };
            Console.WriteLine(arry.Length);
            Console.WriteLine(arry.Rank);
            //length property can be useful in for loops when we want to specify the number of times the loop should run
            for(int k = 0; k< arry.Length; k++)
            {
                Console.WriteLine(arry[k]);
            }
            //Array method
            //There are a number of methods available for arrays, Max returns the largest value, Min returns the smallest value, Sum returns the sum of all elements
            int[] arys = { 3, 5, 8, 4 };
            Console.WriteLine(arys.Max());
            Console.WriteLine(arys.Min());
            Console.WriteLine(arys.Sum());


            /*
             * Strings
             * strings in C# are object, when you declare a string variable, you basically instantiate an object of type String.
             * String objects suport a number of useful properties and methods:
             * - Length returns the length of the string.
             * - IndexOf(value) returns the index of the first occurence of the value within the string
             * - Insert(index, value) inserts the value into the string starting from the specified index
             * - Remove(index) removes all characters in the string after the specified index.
             * - Replace(oldValue, newValue) replaces the specified value in the string
             * - Substring(index, length) returns a substring of the specified length, starting from the specified index. If length is not specified,
             *   the operation continues to the end of the string
             * - Contains(value) returns true if the string contains the specified value.
             * Examples below demonstrate each String member  
             */
            string ae = "some fun text";
            //Length
            Console.WriteLine(ae.Length); //output 13
            //IndexOf
            Console.WriteLine(ae.IndexOf("f")); //output 5
            //Insert
            ae = ae.Insert(0, "This is ");
            Console.WriteLine(ae); //output "This is some fun text"
            //Replace
            ae = ae.Replace("text", "code");
            Console.WriteLine(ae); //output "This is some fun code"
            //Contains
            if(ae.Contains("fun"))
            {
                Console.WriteLine("yea");  //output yea
            }
            //Remove
            ae = ae.Remove(16);
            Console.WriteLine(ae); //output "This is some fun"
            //Substring
            ae = ae.Substring(5);
            Console.WriteLine(ae); //output "is some fun"
            //we can also access characters of a string by its index, just like accessing element of an array
            Console.WriteLine(ae[6]); //output is e cos ae = "is some fun" now

            //let's create a progeam that will take a string, replace all occurences of the word "dog" with "cat" and output the first sentence only
            string test = "This is some test about a dog. the word dog appears in the text a number of times. this is the end.";

            test = test.Replace("dog", "cat");
            test = test.Substring(0, test.IndexOf(".") + 1);
            Console.WriteLine(test);//output - This is some test about a cat.


        }
    }
}
