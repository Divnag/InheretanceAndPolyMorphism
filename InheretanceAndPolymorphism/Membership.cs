using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
   public class Membership
    {

        //fields
        private int memberID;
        private bool isActive;


        //properties

        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }


        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }


        //constructors
        public Membership()
        {

        }

        public Membership(int memberID,bool isActive)
        {
            this.memberID = memberID;
            this.isActive = isActive;

        }

        //method
        public virtual void Activate()
        {
            if(isActive==false)
            {
                isActive = true;
                Console.WriteLine("Youe Membership has been activated,\nMember ID: "+memberID);
                
            }
            else
            {
                Console.WriteLine("Your Membership is already active\nMember ID "+memberID);
            }
        }


    }
}
