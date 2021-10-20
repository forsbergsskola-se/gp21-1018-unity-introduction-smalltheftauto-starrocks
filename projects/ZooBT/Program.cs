using System;

namespace ZooBT
{
	class Program
    {
	    class Animal {
        
	    }
	    class Mammal : Animal {
        
	    }
	    class Bear : Mammal {
        
	    }
	    class Donkey : Mammal {
        
	    }
	    class Lion : Mammal {
        
	    }
	    class Fish : Animal {
        
	    }
	    class Salmon : Fish {
        
	    }
	    class Clownfish : Fish {
        
	    }
	    class Student {
        
	    }
	    class Zoo <TCreature> where TCreature : Animal, new() {
		    private TCreature[] animals;

		    public void Oversize() {
			    Array.Resize(ref animals, animals.Length + 1);
		    }
		    public TCreature AddAnimal<TCreature> (TCreature animal) where TCreature : Animal, new () {
			    animal = new TCreature();
			    return animal;
		    }
		    public bool HasAnimal<TCreature>() {
			    return false;
		    }
	    }

	    static void Main(string[] args)
        {
	        {
		        Zoo<Fish> fishZoo = new Zoo<Fish>();
		        fishZoo.AddAnimal(new Fish()); // OKAY
		        fishZoo.AddAnimal(new Clownfish()); // OKAY
	        }
	        {
		        Zoo<Animal> animalZoo = new Zoo<Animal>();
		        animalZoo.AddAnimal(new Fish()); // OKAY
		        animalZoo.AddAnimal(new Clownfish()); // OKAY
		        animalZoo.AddAnimal(new Lion()); // OKAY
		        animalZoo.AddAnimal(new Donkey()); // OKAY
	        }
        }
    }
}
