using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals
{
    public abstract class Animal : IRunnable
    {
        // State
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }

        // Behaviour
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public abstract void MakeNoise();

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
