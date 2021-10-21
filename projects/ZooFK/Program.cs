using System;
using System.Collections.Generic;
using System.Linq;

namespace ZooFK
{
    class Program
    {
        public class Animal{}
        public class Mammal : Animal{}
        public class Bear : Mammal{}
        public class Donkey : Mammal{}
        public class Lion : Mammal{}
        public class Fish : Animal{}
        public class Salmon : Fish{}
        public class Clownfish : Fish{}
        public class Student{}
        
 
        
        static void Main()
        {
        Zoo<Mammal> mammalZoo = new Zoo<Mammal>();
        Zoo<Fish> fishZoo = new Zoo<Fish>();
        Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();
        fishZoo.AddAnimal(new Fish());
        
        Console.WriteLine(fishZoo.HasAnimal<Fish>());
        Console.WriteLine(fishZoo.HasAnimal<Donkey>());
        }
        class Zoo<TAnimal> where TAnimal : Animal
        {
            private List<TAnimal> animals = new List<TAnimal>();

            public void AddAnimal(TAnimal animal)
            {
                this.animals.Add(animal);
            }

            public bool HasAnimal<TSpecies>()
            {
                for (int i = 0; i < animals.Count(); i++)
                {
                    if (typeof(TSpecies) == animals[i].GetType())
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
    

