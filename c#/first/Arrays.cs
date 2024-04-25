using System;

namespace Arrays
{
    class Arrays
    {
        static void ArrayMain(string[] a)
        {
            /*
                Creating array
                datatype[] arr_name = new datatype[size_of_array]
                ie. int[] x = new int[6];
            
            
            
            
            int[] arr = { 2, 4, 5, 6, 7, 9, 10 };
            int[] arr2 = new int[] { 11, 32, 45, 66, 22, 55, 44, 777 };// Both syntax are same


            Console.Write(" First array : ");
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }

            Console.Write("\n Second array : ");
            foreach (var item in arr2)
            {
                Console.Write(item + "  ");
            }

            int[] dummy = new int[15];
            */
            // arr2.CopyTo(dummy,0);   //dummy = 11  32  45  66  22  55  44  777  0  0  0  0  0  0  0
            /*
                srcArr.CopyTo(destArr,n)
                Here n specify to skip n index in destination array and then assign
            
            arr2.CopyTo(dummy,3);   //dummy = 0  0  0  11  32  45  66  22  55  44  777  0  0  0  0

            Console.Write("\n Dummy array : ");
            foreach (var item in dummy)
            {
                Console.Write(item + "  ");
            }

            Array.Sort(dummy);      //To sort a array
            Console.Write("\nSorted dummy arr : ");
            foreach (var item in dummy)
                Console.Write(item + "  ");

            Array.Reverse(dummy);   //To reverse a array

            Console.WriteLine("\nin dummy at index 2 is {0}",dummy.GetValue(4));

            int[] numbers = { 1, 2, 3, 4, 5, 3 };
            int index = Array.IndexOf(numbers, 3); // index = 2
            int lastIndex = Array.LastIndexOf(numbers, 3); // lastIndex = 5
            */

            /*
                2D array
            */

            /*
            int[,] TwoD = {{12,32,34,53},{43,46,65,57}};

            // it specify no. of 1d array in 2array
            Console.WriteLine(TwoD.GetLength(0));   // returns no. of rows

            // it specify no. of element in 1d array
            Console.WriteLine(TwoD.GetLength(1));   // returns no. of columns

            // Printing 2D array
            Console.WriteLine("Two dimension array : ");
            for (int i = 0; i < TwoD.GetLength(0); i++)
            {
                for (int j = 0; j < TwoD.GetLength(1); j++)
                {
                    Console.Write($"  {TwoD[i,j]}");
                }
                Console.WriteLine();
            }
            */
            // Jagged Arrays (Array of Arrays):

            /*

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] {2,5,6,7,9,0,9};
            jaggedArray[1] = new int[] {23, 43, 45, 16, 67,98,67};
            jaggedArray[2] = new int[] {123,435,232,547,111};

            // Printing jagged array
            Console.WriteLine("jagged array is : ");
            foreach (int[] item in jaggedArray)
            {
                foreach (var x in item)
                {
                    Console.Write($"  {x}");
                }
                Console.WriteLine();
            }

            */

            /*

            👉 Rectangular vs. Jagged Arrays:

               🌟 Rectangular arrays have fixed dimensions, whereas jagged arrays can have varying dimensions for each row.
            
               🌟 Rectangular arrays are more memory-efficient, whereas jagged arrays provide more flexibility.

            */



            /* 
                Get length of 2d array
            */
            // int[,] matrix = new int[3, 4];
            // int rows = matrix.GetLength(0); // Returns the number of rows (3)
            // int columns = matrix.GetLength(1); // Returns the number of columns (4)
            /*
                Rank returns the dimension of multi-dimension array
                In case of 2D array it returns 2
            */
            // int[,] matrix = new int[3, 4];
            // int rank = matrix.Rank; // Returns the rank of the array (2)

            /*
                Creates a shallow copy of the array
            */
            int[,] matrix = new int[3, 4];
            int[,] copy = (int[,])matrix.Clone(); // Creates a shallow copy of the array
            
            // Inserting values into matrix array
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = i*j;
                }
            }
            // Printing elements of matrix array
            Console.WriteLine("Printing array elements");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("  {0}",matrix[i,j]);
                }
                Console.WriteLine();
            }

            // 
            Console.WriteLine("Printing copy array elements");
            for (int i = 0; i < copy.GetLength(0); i++)
            {
                for (int j = 0; j < copy.GetLength(1); j++)
                {
                    Console.Write("  {0}",copy[i,j]);
                }
                Console.WriteLine();
            }


            /*
                GetValue() and SetValue():
            

            int[,] matrix2 = new int[3, 3];
            int value = (int)matrix2.GetValue(0, 0); // Gets the value at row 0, column 0
            matrix2.SetValue(10, 0, 0); // Sets the value at row 0, column 0 to 10

            */




            

            Console.WriteLine();
            
        }
    }
}