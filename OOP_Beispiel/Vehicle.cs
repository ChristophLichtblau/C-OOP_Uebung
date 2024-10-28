using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    abstract class Vehicle
    {
        public int DoorCount { get; set; }
        public float Acceleration { get; set; }
        public float BreakSpeed { get; set; }
        public float Speed { get; set; }



        public void LogInformation() {
            Console.WriteLine("Das Fahrzeug fährt mit " + Speed + " km/h.");
        }

    }
}
