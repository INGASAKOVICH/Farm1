using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farm1;

namespace Farm1
{
    class Farm
    {
        public string FarmName { get; set; }
        public int FarmArea { get; set; }
        public List<Building> Buildings { get; set; }
        public List<GardenBed> GardenBeds { get; set; }
                public void FarmInfo()
        {
            Console.WriteLine($"This is farm {FarmName} with area of {FarmArea} km2.");
                      }
               
    }
}
