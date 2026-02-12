using System;

namespace AnimalsOOPClass.Animals.Birds
{
    /// <summary>
    /// Base class for all Birds, inherits from Animal.
    /// 
    /// It extends to include Wingspan and the ability to make a nest.
    ///
    /// It implements the MakeNoise() method from Animal (even though we are still in an abstract class - it just forces it on non-abstract classes)
    /// </summary>
    public abstract class Bird : Animal
    {
        // Extended state
        public int WingSpanCm { get; }

        public Bird(string name, int wingSpanCm) : base(name) // We send Name to the parent (base = Animal). This is code sharing.
        {
            WingSpanCm = wingSpanCm;
        }

        // Extended behaviour
        public void MakeNest()
        {
            Console.WriteLine($"{Name} is making a nest");
        }

        // Overrides and impl
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} squawks loudly");
        }
    }
}
