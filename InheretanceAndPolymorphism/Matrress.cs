using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class Matrress:Furniture
    {
       


      
        public Matrress(string mattressType,int amount,string brand,string color):base(amount,brand,color)
        {
            Console.WriteLine("matresstype:"+mattressType);
        }

        public void PriceBed()
        {
         
            amount = 600;
        }
    }
}
