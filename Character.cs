using System;
namespace Udemy__OOP
{
    public abstract class Human
    {
        public abstract void SkinColour();
        public abstract void SayName();
        public abstract void PlaceLiving();
        public abstract void Rorar();
    }

    public class AfroAmerican : Human
    {
        private string Skin { get; set; }
        private string Name { get; set; }
        private string Place { get; set; }

        public AfroAmerican(string Skin, string Name, string Place)
        {
            this.Skin = Skin;
            this.Name = Name;
            this.Place = Place;
        }

        public override void PlaceLiving()
        {
            Console.WriteLine($"I am living in {Place}");
        }

        public override void SayName()
        {
            Console.WriteLine($"My name id {Name} !");
        }

        public override void SkinColour()
        {
            Console.WriteLine($"My skin is {Skin}");
        }

        public override void Rorar()
        {
            Console.WriteLine("Hi! I am Afroamerican boy!");
        }


    }
    public class Azian : Human
    {
        private string Skin { get; set; }
        private string Name { get; set; }
        private string Place { get; set; }

        public Azian(string Skin, string Name, string Place)
        {
            this.Skin = Skin;
            this.Name = Name;
            this.Place = Place;
        }

        public override void PlaceLiving()
        {
            Console.WriteLine($"I am living in {Place}");
        }

        public override void SayName()
        {
            Console.WriteLine($"My name id {Name} !");
        }

        public override void SkinColour()
        {
            Console.WriteLine($"My skin is {Skin}");
        }

        public override void Rorar()
        {
            Console.WriteLine("Hi! I am  Azian");
        }
    }
}

