using System;

namespace AnimalsOOPClass.Animals.Mammals
{
    public class Cat : Mammal
    {
        public Cat(string name, bool hasFur) : base(name, hasFur)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} meows");
        }
    }
}
