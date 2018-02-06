using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    public class HogwartsStudent : Wizard
    {
        private int yearInSchool;

        public int YearsInSchool
        {
            get { return this.yearInSchool; }
            set { this.yearInSchool = value; }
        }

        public HogwartsStudent()
        {


        }

        public HogwartsStudent(int yearInSchool)
        {
            this.yearInSchool = yearInSchool;
            this.IsGood = true;
        }

        public int Study()
        {
            return yearInSchool++;
        }

        public override void MakeMagic()
        {
            Console.WriteLine("Derived class method in Hogwartstudent");
            
        }
    }
}
