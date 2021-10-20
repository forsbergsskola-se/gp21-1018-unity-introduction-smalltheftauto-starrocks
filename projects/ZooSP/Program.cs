using System;
using ZooSP.Classes;

namespace ZooSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo<Mammals> zoo = new Zoo<Mammals>();
            zoo.AddAnimal(new Bear());
            zoo.AddAnimal(new Donkey());
            zoo.AddAnimal(new Lion());
            zoo.PrintOutZooInhabitants();

            Zoo<Fish> aquarium = new Zoo<Fish>();
            aquarium.AddAnimal(new Salmon());
            aquarium.AddAnimal(new ClownFish());
            aquarium.PrintOutZooInhabitants();

            Zoo<Animal> skansen = new Zoo<Animal>();
            skansen.AddAnimal(new Lion());
            skansen.AddAnimal(new Salmon());
            skansen.PrintOutZooInhabitants();

            Zoo<Lion> colliseum = new Zoo<Lion>();
            colliseum.AddAnimal(new Lion());
            colliseum.AddAnimal(new Lion());
            skansen.PrintOutZooInhabitants();
        }
    }
}
