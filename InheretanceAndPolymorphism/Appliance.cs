using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public abstract class Appliance
    {
        //fields
        private bool isElectric;

        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }


        //construstors-none

        //methods
        public abstract void Work();
        

        
            
    }
}
