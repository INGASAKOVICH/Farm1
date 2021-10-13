using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farm1;

namespace Farm1
{
    public class Plant
    {
        public PlantType Type { get; set; }
        public int OccupiedArea { get; set; }
        public Seasons Planting { get; set; }
        public Seasons Harvesting { get; set; }

    }
}
