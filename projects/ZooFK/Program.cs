using System;

namespace ZooFK
{
    class Program
    {
        private Zoo<Mammal> mammalZoo = new Zoo<Mammal>();
        private Zoo<Fish> fishZoo = new Zoo<Fish>();
        private Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();
        static void Main()
        {
            fishZoo.AddAnimal(new Fish());
        }
    }

    class Animal
    {
        
    }

    class Mammal : Animal
    {
        
    }
    class Bear : Mammal
    {
        
    }
    class Donkey : Mammal
    {
        
    }
    class Lion : Mammal
    {
        
    }
    

    class Fish : Animal
    {
        
    }
    class Salmon : Fish
    {
        
    }
    class Clownfish : Fish
    {
        
    }

    class Student
    {
        
    }

    class Zoo<TAnimal> where TAnimal : Animal 
    {
        public void AddAnimal(TAnimal newAnimal)
        {
            TAnimal animal = newAnimal;
        }

        public bool HasAnimal(TAnimal animal)
        {
            
        }
    }
}
    

