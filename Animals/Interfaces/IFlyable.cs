using System;

namespace AnimalsOOPClass.Animals.Interfaces
{
    /// <summary>
    /// Contract to say "I am able to fly".
    /// The implementing class is required to provide how they do this.
    /// </summary>
    public interface IFlyable
    {
        public void Fly();
    }
}
