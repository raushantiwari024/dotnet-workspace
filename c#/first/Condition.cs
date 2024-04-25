// See https://aka.ms/new-console-template for more information

using System;

namespace DemoProgram{
    class Program{
        static void Test(string[] args){
            // Console.WriteLine("Hello C#");
            // Console.WriteLine("Enter your name : ");
            // // string name = Console.ReadLine();
            // string name = "Raushan";
            // Console.WriteLine("Your name is "+name);//Concatination syntax
            // Console.WriteLine("Your name is {0}",name);//Placeholder syntax

            // Console.Write("Enter a number");
            // int x = int.Parse(Console.ReadLine());
            
            // Console.WriteLine(int.MinValue);
            /*
            unchecked
            {
            int x = int.MaxValue;
            int y=x+1;
            Console.WriteLine("number is {0}",y);
            }

            */

            // Print weakDay according to week number

            /*
            Console.Write("Enter week number : ");
            
            int? num = Convert.ToInt32(Console.ReadLine());

            switch (num ?? 0)
            {
                case 1:
                    Console.WriteLine(" Today is monday ");
                    break;
                case 2:
                    Console.WriteLine(" Today is tuesday");
                    break;
                case 3:
                    Console.WriteLine(" Today is wednesday");
                    break;
                case 4:
                    Console.WriteLine(" Today is thursday");
                    break;
                case 5:
                    Console.WriteLine(" Today is friday");
                    break;
                case 6:
                    Console.WriteLine(" Today is saturday");
                    break;
                case 7:
                    Console.WriteLine(" Today is sunday");
                    break;
                default:
                        Console.WriteLine(" Invalid day number {0}",num);
                        break;
            }
            */

            /*
            int x=1;
            switch (x)
            {
                case 1://if a case has no statement then it will not make error but if a case containing some statements and not including a break statement then it will make error
                case 2:
                    Console.WriteLine("case 2");
                    break;
                
                default:
                    Console.WriteLine("default case.......");
                    break;
            }
            */

            // int x = 20;
            // Console.WriteLine($"Hello {x*2}");


        }
    } 
}