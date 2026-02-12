using System;

namespace AnimalsOOPClass.Animals.Interfaces
{
    /// <summary>
    /// Contract to say "I am able to swim".
    /// The implementing class is required to provide how they do this.
    /// </summary>
    public interface ISwimmable
    {
        public void Swim();
    }
}
