using System;

namespace Iteration
{
    class Loops
    {
        static void LoopMain(string[] a){
            // While loop
            /*
            int x=0;
            while (x<10)
            {
                Console.Write($"{x++}  ");
            }
            Console.WriteLine();

            
                Example of for loop

                Printing table of  10
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"10 * {i} = {10*i} ");
            }
            */

            /*
                Foreach loop
            */
            int[] arr = {2,4,5,6,78,8,2};
            foreach (int item in arr)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine();
        }
    }
}