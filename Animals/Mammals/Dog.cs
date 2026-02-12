using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals.Mammals
{
    /// <summary>
    /// Concrete class inhertiting from Mammal, and implementing the ISwimable and IRunnable interface.
    /// 
    /// It extends to include the breed of the dog, and the ability to play.
    /// </summary>
    public class Dog : Mammal, ISwimmable, IRunnable
    {
        // Extension
        public string Breed { get; }

        public Dog(string name, bool hasFur, string breed) : base(name, hasFur)
        {
            Breed = breed;
        }

        // Extended methods
        public void Play()
        {
            Console.WriteLine($"{Name} is playing with a ball");
        }

        // Overrides and impl
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating kibllets");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} barks");
        }

        public void Swim() // From ISwimmable
        {
             Console.WriteLine($"{Name} dives in");
        }

        public void Run() // From IRunnable
        {
            Console.WriteLine($"{Name} gallops furiously");
        }
    }
}
