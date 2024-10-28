using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    internal class MotorCycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("2 Räder haben Bodenkontakt!");
        }
    }
}
