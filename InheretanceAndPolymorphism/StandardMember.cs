using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
   public class StandardMember:Membership
    {
        //fields
        //invisible


        //properties
        public int Cost { get; set; }//short hand creates invisible fields
        //construsctors
        public StandardMember()
        {

        }

        public StandardMember(int cost):base (1089,true)
        {
            Cost = cost;
        }

        //method
        public override void Activate()
        {
            base.Activate();
            int anualFee = 100 * 12;

            Console.WriteLine("Standard Standard Anual fee:" + anualFee+"\n");

        }
    }
}
