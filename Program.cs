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
        

        List<ISwimable> swimmers = new List<ISwimable>();
        swimmers.Add(pauly);
        swimmers.Add(eagly);
        swimmers.Add(pluto);

        foreach (var swimmer in swimmers)
        {
            swimmer.Swim();
        }

    }
}