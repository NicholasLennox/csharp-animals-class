using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals.Birds
{
    /// <summary>
    /// Concrete class inhertiting from Bird, and implementing the ISwimable and IFlyable interfaces.
    /// 
    /// It extends to include if the eagle is bald. 
    /// </summary>
    public class Eagle : Bird, IFlyable, ISwimmable
    {
        // Extended state
        public bool IsBald { get; set; }

        public Eagle(string name, int wingSpanCm, bool isBald) : base(name, wingSpanCm) // Send name and wingSpanCm to Bird, which sends name to Animal. More code sharing.
        {
            IsBald = isBald;
        }

        // Overrides and impl
        public override void MakeNoise()
        {
            base.MakeNoise(); // Bird.MakeNoise(), if it doesnt exist, Animal.MakeNoise() -> it walks up the chain until it finds an implementaion
            Console.WriteLine($"but it doesnt sound like the movies, because that is a redtail hawk");
        }

        public void Fly() // From IFlyable interface
        {
            Console.WriteLine($"{Name} soars high above");
        }

        public void Swim() // From ISwimable interface
        {
            Console.WriteLine($"{Name} dives in and uses his wings as finns - terrifiying the local fish");
        }
    }
}
