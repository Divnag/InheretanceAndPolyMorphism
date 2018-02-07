using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class VIPMember:Membership
    {

        //fields
        //invisble

        //properties
        public bool IsSwanky { get; set; }


        //constructor
        public VIPMember() : base(187, false)
        {

        }
        public VIPMember(bool isswanky)
        {
            this.IsSwanky = isswanky;
        }

        //methods
        public override void Activate()
        {
            IsSwanky = true;
            base.Activate();
            int annualfee = 90;
            annualfee = 90 * 12;
            Console.WriteLine("your VIP Annual fee:"+annualfee);
        }
    }
}
