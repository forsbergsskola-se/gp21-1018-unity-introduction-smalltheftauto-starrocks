using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZooSP.Classes
{
    public class Zoo<T>
    {
        private List<T> zooPopulation = new List<T>();

        public void AddAnimal(T animal)
        {
            zooPopulation.Add(animal);
        }
    }
}