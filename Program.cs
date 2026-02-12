using AnimalsOOPClass.Animals;
using AnimalsOOPClass.Animals.Birds;
using AnimalsOOPClass.Animals.Interfaces;
using AnimalsOOPClass.Animals.Mammals;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog pluto = new Dog("Pluto", true, "Disney Special");

        // pluto.MakeNoise(); // Animal
        // pluto.NurseYoung(); // Mammal
        // pluto.Play(); // Dog

        Eagle eagly = new Eagle("Eagly the Prime Eagle", 100, true);

        // eagly.DiveBomb(); // Eagle
        // eagly.MakeNest(); // Bird
        // eagly.MakeNoise(); // Animal
        eagly.Fly();

        Penguine pauly = new Penguine("Pauly the Emperor", 60, 25);

        pauly.Eat();
        pauly.MakeNest();
        pauly.SlideIntoDM();
        pauly.MakeNoise();


        List<ISwimmable> swimmers = new List<ISwimmable>();
        swimmers.Add(pauly);
        swimmers.Add(eagly);
        swimmers.Add(pluto);

        foreach (var swimmer in swimmers)
        {
            swimmer.Swim();

            if (swimmer is IFlyable flyer) // I am forcing this to show a keyword that is useful for the KATA.
            {
                flyer.Fly(); // Swimmers who can also fly (only eagly in this case)
            }

            // The 'is' keyword can check whether an object implements an interface (or is of a certain type).
            // 
            // In this case, we check if the current swimmer also implements IFlyable.
            // 
            // The syntax:
            //     if (swimmer is IFlyable flyer)
            //
            // does TWO things:
            // 1. Checks if swimmer can be treated as IFlyable.
            // 2. If true, it safely converts (casts) swimmer to IFlyable
            //    and assigns it to a new variable called "flyer".
            //
            // We need the new name ("flyer") because the original variable
            // is typed as whatever the loop gives us (ISwimmable).
            // That type does not contain Fly(), so we cannot call Fly() on it directly.
            //
            // The new variable has the IFlyable type, which exposes Fly().
        }

    }
}