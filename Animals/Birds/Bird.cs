using System;

namespace AnimalsOOPClass.Animals.Birds
{
    public class Bird : Animal
    {
        // Extended state
        public int WingSpanCm { get; }

        public Bird(string name, int wingSpanCm) : base(name)
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
