using System;

namespace AnimalsOOPClass.Animals.Mammals
{
    /// <summary>
    /// Base class for all Mammals, inherits from Animal.
    /// 
    /// It extends to include fur and the ability to make a nurse young.
    ///
    /// </summary>
    public abstract class Mammal : Animal // A mammal IS-A animal
    {
        // Extended state
        public bool HasFur { get; }

        public Mammal(string name, bool hasFur) : base(name)
        {
            HasFur = hasFur;
        }

        // Extended behaviour
        public void NurseYoung()
        {
            Console.WriteLine($"{Name} is nursing their young");
        }
    }
}
