using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals.Birds
{
    public class Eagle : Bird, IFlyable, ISwimable
    {
        public bool IsBald { get; set; }
        public Eagle(string name, int wingSpanCm, bool isBald) : base(name, wingSpanCm)
        {
            IsBald = isBald;
        }

        // 
        public void DiveBomb()
        {
            Console.WriteLine($"{Name} swoops up high, then lykke til");
        }

        public override void MakeNoise()
        {
            base.MakeNoise(); // Squawking
            Console.WriteLine($"but it doesnt sound like the movies, because that is a redtail hawk");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} soars high above");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} uses his wings as finns");
        }
    }
}
