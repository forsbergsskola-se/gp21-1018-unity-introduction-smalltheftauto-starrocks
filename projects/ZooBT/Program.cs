using System;

namespace ZooBT {
	class Program {
	    class Animal {}
	    class Mammal : Animal {}
	    class Bear : Mammal {}
	    class Donkey : Mammal {}
	    class Lion : Mammal {}
	    class Fish : Animal {}
	    class Salmon : Fish {}
	    class Clownfish : Fish {}
	    class Student {}
	    
	    class Zoo <TAnimal> where TAnimal : Animal, new() {
		    TAnimal[] animals = new TAnimal[0];

		    public void AddAnimal(TAnimal animal) {
			    Array.Resize(ref animals, animals.Length + 1);
			    animals[animals.Length - 1] = animal;
		    }
		    
		    public bool HasAnimal<TSoecies>() where TSoecies : TAnimal{
			    throw new NotImplementedException();
		    }
	    }

	    static void Main(string[] args) {
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
	        {
		        Zoo<Lion> lionZoo = new Zoo<Lion>();
		        lionZoo.AddAnimal(new Lion()); // OKAY
		        lionZoo.AddAnimal(new Lion()); // OKAY
		        lionZoo.AddAnimal(new Lion()); // OKAY
	        }
	        // {
		       //  Zoo<Student> studentZoo = new StudentZoo(); // ERROR!
	        // }
	        // {  
		       //  Zoo<Fish> fishZoo = new Zoo<Fish>();
		       //  fishZoo.AddAnimal(new Lion()); // ERROR!
	        // }
	        // {
		       //  Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
		       //  salmonZoo.AddAnimal(new Fish()); // ERROR!
	        // }
	        // {
		       //  Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
		       //  salmonZoo.HasAnimal<Lion>(); // ERROR!
	        // }
	        {
		        Zoo<Fish> fishZoo = new Zoo<Fish>();
		        fishZoo.AddAnimal(new Salmon());
		        fishZoo.AddAnimal(new Salmon());
		        Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
	        }
        }
    }
}
