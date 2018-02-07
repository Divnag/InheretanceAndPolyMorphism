using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAnd_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sofa furniture = new Sofa("sectional",1000,"Ashley","white");
              furniture.Options();

             Matrress bedFurniture = new Matrress("King", 600, "Temperpudic", "soft");
             bedFurniture.Options();



             Wizard wizardOne = new Wizard(true);
             HogwartsStudent longBottom = new HogwartsStudent();
             DeathEater malfoy = new DeathEater();
             wizardOne.MakeMagic();
             longBottom.MakeMagic();
             malfoy.MakeMagic();*/




            /*
                        StandardMember member1 = new StandardMember(10);
                        VIPMember member2 = new VIPMember();
                        member1.Activate();
                        member2.Activate();*/






            MicroWave myMicroWave = new MicroWave(1000, "samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicroWave.Work();
            myDishwasher.Work();

        }
    }
}
