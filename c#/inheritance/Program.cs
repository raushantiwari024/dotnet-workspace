using System;

namespace InheritanceTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Memal m=new Memal();

            m.Barking();
            m.Running();


        }
    }

    public class Pet
    {
        string? color;
        public Pet(string color){
            this.color = color;
        }
        public Pet(){}
        public string Color{
            set {color = value;}
            get {return color;}
        }
        public virtual void Barking(){
            Console.WriteLine("barking.........");
        }
    }

    public class Memal: Pet
    {
        int height;

        public int Height{
            get {return height;}
            set {height = value;}
        }

        public void Running(){
            Console.WriteLine("Running..............");
        }

        public override void Barking(){
            Console.WriteLine("Memal is barking.........");
        }
    }
}