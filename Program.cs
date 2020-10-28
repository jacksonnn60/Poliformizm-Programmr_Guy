using System;

namespace Udemy__OOP
{


    class Program
    {
        static void Main(string[] args)
        {
           

            Azian Chunhan = new Azian("yellow", "Chunhan", "Pekin");
            AfroAmerican Billy = new AfroAmerican("Dark-Brown", "Billy", "Egypt");

            Chunhan.SayName();
            Chunhan.PlaceLiving();
            Chunhan.SkinColour();
            Chunhan.Rorar();

            Console.WriteLine();


            Billy.SayName();
            Billy.PlaceLiving();
            Billy.SkinColour();
            Billy.Rorar();

            Console.WriteLine();

            Guy billy = new Guy();

            billy.Hello();
            billy.HowOldYou();
            billy.SayAll();
        }

        public class Guy
        {

            public string Name { get; set; }
            public int Age { get; set; }


            public void Hello()
            {
                Console.WriteLine("What is your name?:");
                this.Name = Console.ReadLine();
            }

            public void HowOldYou()
            {
                Console.WriteLine("What is your age ?:");
                this.Age = int.Parse(Console.ReadLine());
            }

            public void SayAll()
            {
                Console.WriteLine("Your name is:" + Name);
                Console.WriteLine("Your age is:" + Age);
            }


        }

    }
}
