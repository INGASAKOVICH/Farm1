using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farm1;

namespace Farm1
{
    public class Building
    {
        public string Name { get; set; }
        public int BuildingArea { get; set; }
        public List<Animal> AnimalsInBarn { get; set; }
        
        public void BuildingInfo()
        {
            Console.WriteLine($"{Name} with area {BuildingArea} and animals:");
            foreach (var animal in AnimalsInBarn)
            {
                Console.WriteLine(animal);
            }




        }

    }
}
