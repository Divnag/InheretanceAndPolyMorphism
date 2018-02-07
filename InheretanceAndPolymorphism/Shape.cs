using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class Shape
    {
        //fields
        private int sides;
        //property
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }
        //constructor
        public Shape()
        {

        }


        public Shape(int sides)
        {

            this.sides = sides;
        }

        //methods


    }
}
