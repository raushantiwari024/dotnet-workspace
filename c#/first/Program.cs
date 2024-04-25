using System;
using ClassAndObject;

class Program
{
    string? name;
    public static void Main(string[] a)
    {
        Student stud;
        stud = new Student();

        stud.Roll = 10;
        stud.Name = "Raushan";
        stud.Age = 24;
        stud.City = "Bagaha";

        Console.WriteLine($"Roll : {stud.Roll}, Name : {stud.Name}, Age : {stud.Age} and City : {stud.City}");

        Program p = new Program();
        p.name = "Raushan";
        Console.WriteLine(p.name);

        /*

        string? name = null;

        if(name == null)
            Console.WriteLine("name is null");
        else
            Console.WriteLine("Name is not null");

        */


         Console.WriteLine();
    }
}