using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
   public class Rectangle : Shape
    {

        private double area;
        //property Paschal
        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        //derived class does not inherit the constuctors of the 
        //base class.however the constructors of the base class
        //can be accessed using the "base" keyword.
        public Rectangle(double area)
        {
            this.area = area;
        }


        //default constructor and base class constructor does same thing
        /*public Rectangle():base()
        {

        }
        public Rectangle(double area) : base(4)
        {

        }*/


    } 
}
