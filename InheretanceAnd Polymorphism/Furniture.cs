using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
   public class Furniture
    {
        
        protected int amount;
        private string brand;
        private string color;


        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }


        public  Furniture()
        {

        }
      


        public Furniture(int amount,String brand,string color)
        {
            
            this.amount = amount;
            this.color = color;
            this.brand = brand;
        }

       
        public void Options()
        {
            
            Console.WriteLine(" Color Perfered: "+color+"\nAmount: "+amount+"\nbrand: "+brand);
        }

}

}
