using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    class Helicopter : Plane
    {
        public override void Landing()
        {
            base.Landing();

            Console.WriteLine("Der Helicopter landet!");
        }
    }
}
