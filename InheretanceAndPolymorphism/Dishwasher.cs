using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class Dishwasher:Appliance
    {


        //fields
        //invisble

        //properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        //constructors
        public Dishwasher()
        {


        }

        public Dishwasher(double decibelLevel,bool hasHeatDry)
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        //method

        public override void Work()
        {
            Console.WriteLine("I wash your dishes");
        }

    }
}
