using System;
using AnimalsOOPClass.Animals.Interfaces;
using AnimalsOOPClass.Animals.Mammals;

namespace AnimalsOOPClass.Animals.Birds
{
    /// <summary>
    /// Concrete class that extends bird, Penguines cant fly, but can swim.
    /// </summary>
    public class Penguine : Bird, ISwimmable
    {
        // Extended state
        public int TopSpeed { get; }

        public Penguine(string name, int wingSpanCm, int topSpeed) : base(name, wingSpanCm) // Sends name and wingSpanCm to Bird, bird sends name to Animal
        {
            TopSpeed = topSpeed;
        }

        // Extended behaviour
        public void SlideIntoDM()
        {
            Console.WriteLine($"{Name} kidnaps all the small penguines for his own island");
        }

        // Overrides and impl
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} makes a noise that makes you question reality");
        }

        public void Swim() // From ISwimable interface
        {
            Console.WriteLine($"{Name} glides effortlesly through the water");
        }
    }
}
