using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class DeathEater:Wizard
    {
        //fields
        private bool hasDarkmark;
        //properties
        public bool HasDarkMark
        {
            get { return this.hasDarkmark; }
            set { this.hasDarkmark = value; }
        }

        //constructors
        public DeathEater():base(false)
        {

        }

        //method
        public override void MakeMagic()
        {
            Console.WriteLine("Method from derived class Deatheater");
        }
    }
}
