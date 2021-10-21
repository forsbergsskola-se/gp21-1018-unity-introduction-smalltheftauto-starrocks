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
        
        
        Zoo<Animal> animalZoo = new Zoo<Animal>();
        animalZoo.AddAnimal(new Salmon());
        animalZoo.AddAnimal(new Lion());
        animalZoo.AddAnimal(new Donkey());
        Console.WriteLine("This should be True: "+animalZoo.HasAnimal<Fish>());
        }
        class Zoo<TAnimal> where TAnimal : Animal
        {
            private List<TAnimal> animals = new List<TAnimal>();

            public void AddAnimal(TAnimal animal)
            {
                this.animals.Add(animal);
            }

            public bool HasAnimal<TSpecies>() where TSpecies : TAnimal {
                for (int i = 0; i < this.animals.Count; i++) {
                    if (this.animals[i] is TSpecies) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
    

