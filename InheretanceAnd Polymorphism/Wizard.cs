using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class Wizard
    {

        //fields

        private bool isGood;

        //properties
        public bool IsGood
        {
            get { return this.isGood; }
            set { this.isGood = value; }
        }

        public Wizard()
        {

        }

        public Wizard(bool isGood)
        {
            this.isGood = isGood;
        }

        public virtual void MakeMagic()
        {
            Console.WriteLine("Base class Method");
        }

    }
    

}
