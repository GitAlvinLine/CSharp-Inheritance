using System;

namespace CSharp_Inheritance_example
{

    public class Mario
    {
        protected string Name;
        protected string Strenth;
        protected int Health;
        protected int Armor;

        public Mario(string name, string strength, int health, int armor)
        {
            this.Name = name;
            this.Strenth = strength;
            this.Health = health;
            this.Armor = armor;
        }
        public void Stats()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Strength: " + Strenth);
            System.Console.WriteLine("Health: " + Health);
            System.Console.WriteLine("Armor: " + Armor);
        }
    }

    public class Luigi : Mario
    {
        public Luigi(string name, string strength, int health, int armor) : base(name, strength, health, armor)
        {
            this.Name = name;
            this.Strenth = strength;
            this.Health = health;
            this.Armor = armor;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario("Mario","Technique",100,100);
            mario.Stats();
            System.Console.WriteLine();
            Luigi luigi = new Luigi("Luigi","Technique and Agility", 130, 150);
            luigi.Stats();
        }
    }
}
