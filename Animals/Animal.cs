using System;
using AnimalsOOPClass.Animals.Interfaces;

namespace AnimalsOOPClass.Animals
{
    /// <summary>
    /// Base class for all Animals.
    /// It contains shared state (Name) and common behaviour (Eat() and MakeNoise()).
    /// We have a default implementation for Eat(), so we mark it with virtual so that children classes can override (do differently).
    /// We do not have a default implementation for MakeNoise() so we mark it abstract (only availble in an abstract class - since no instances can be made).
    /// </summary>
    public abstract class Animal
    {
        // State
        public string Name { get; } // Keep it read-only, its set once during construction.

        /// <summary>
        /// We do not allow a default constructor, just one that requires a name to be supplied.
        /// </summary>
        /// <param name="name">Name of the Animal, e.g., Donald Duck</param>
        public Animal(string name)
        {
            Name = name;
        }

        // Behaviour
        public virtual void Eat() // Has default implementation children can override
        {
            Console.WriteLine($"{Name} is eating");
        }

        public abstract void MakeNoise(); // Has no default implementation, concrete (not abstract) children need to implement this.
    }
}
