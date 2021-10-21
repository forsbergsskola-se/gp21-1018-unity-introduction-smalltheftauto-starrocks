using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZooSP.Classes
{
    public class Zoo<TAnimal> where TAnimal : Animal
    {
        private List<TAnimal> _zooPopulation = new();

        public void AddAnimal(TAnimal animal)
        {
            _zooPopulation.Add(animal);
            Console.WriteLine(animal + " has been added to the zoo.");
        }

        public void PrintOutZooInhabitants()
        {
            foreach (var inhabitant in _zooPopulation)
            {
                Console.WriteLine(inhabitant);
            }
        }

        // This method has it's own constrains
        public bool HasAnimal<TSpecies>() where TSpecies : TAnimal
        {
            for (int i = 0; i < _zooPopulation.Count; i++)
            {
                if (_zooPopulation[i] is TSpecies)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}