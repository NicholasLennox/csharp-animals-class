using System;
using AnimalsOOPClass.Animals.Interfaces;
using AnimalsOOPClass.Animals.Mammals;

namespace AnimalsOOPClass.Animals.Birds
{
    public class Penguine : Bird, ISwimable
    {
        public int TopSpeed { get; }

        public Penguine(string name, int wingSpanCm, int topSpeed) : base(name, wingSpanCm)
        {
            TopSpeed = topSpeed;
        }

        public void SlideIntoDM()
        {
            Console.WriteLine($"{Name} kidnaps all the small penguines for his own island");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} makes a noise that makes you question reality");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} glides effortlesly through the water");
        }
    }
}
