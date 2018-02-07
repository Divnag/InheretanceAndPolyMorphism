using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class MicroWave : Appliance
    {

        //fields
        private int watts;
        private string brand;

        //properties
        public int Watts
        {
            get { return this.watts; }
            set { this.watts = value; }
        }
        public String Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        //constructors

        public MicroWave()
        {

        }

        public MicroWave(int watts,String brand)
        {
            this.watts = watts;
            this.brand = brand;
        }


        public override void Work()
        {
            Console.WriteLine("Microwave is Working");
        }
    }
}
