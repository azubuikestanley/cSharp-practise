using System;
using System.Collections.Generic;
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

            
            //Array properties 

        }
    }
}
