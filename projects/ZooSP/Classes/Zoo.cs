using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZooSP.Classes
{
    public class Zoo<T>
    {
        public T typeOfAnimals { get; set; }
        
        private List<T> zooPopulation = new List<T>();

        public void AddAnimal(T animal)
        {
            zooPopulation.Add(animal);
            Console.WriteLine(animal + " has been added to the zoo.");
        }

        public void PrintOutZooInhabitants()
        {
            foreach (var inhabitant in zooPopulation)
            {
                Console.WriteLine(inhabitant);
            }
        }
        
        

        
    }
}