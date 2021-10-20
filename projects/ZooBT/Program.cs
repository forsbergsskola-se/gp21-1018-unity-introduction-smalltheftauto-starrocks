using System;

namespace ZooBT
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
    class FishZoo <creature> where creature : Fish {
        public void Activate(creature Salmon) {
           
        }
    }
    class MamalZoo <creature> where creature : Mammal  {
        public void Activate(creature Lion) {
            
        }
    }
    class DonkeyZoo <creature> where creature : Donkey{
        public void Activate(creature Donkey) {
            
        }
    }

    class Program
    {
        public void AddAnimal() {
                
        }
        static void Main(string[] args)
        {

        }
    }
}
