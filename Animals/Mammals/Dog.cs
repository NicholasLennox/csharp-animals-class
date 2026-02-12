using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals.Mammals
{
    public class Dog : Mammal, ISwimable
    {
        public string Breed { get; }
        public Dog(string name, bool hasFur, string breed) : base(name, hasFur)
        {
            Breed = breed;
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing with a ball");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating kibllets");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} barks");
        }

        public void Swim()
        {
             Console.WriteLine($"{Name} dives in");
        }
    }
}
