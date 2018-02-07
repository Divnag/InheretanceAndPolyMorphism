using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class Sofa:Furniture
    {
       
               
            public Sofa(string sofaType, int amount, string brand, string color) :base( amount, brand, color)
        {
            Console.WriteLine( "The living Room Furniture: "+sofaType);
            
        }


        public void price()
        {

            amount = 1000;
        }
    }
}
