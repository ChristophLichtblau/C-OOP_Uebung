namespace OOP_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
          
            Car car = new Car()
            {
                Speed = 200,
                Acceleration = 500,
                BreakSpeed = 50,
                DoorCount = 4
            };
            vehicles.Add(car);


            Plane plane = new Plane()
            {
                Speed = 600,
                Acceleration = 500,
                BreakSpeed = 200,
                DoorCount = 6,
                HasJetDrive = true
            };
            vehicles.Add(plane);


            MotorCycle  motorCycle = new MotorCycle()
             {
                    Speed = 200,
                    Acceleration = 500,
                    BreakSpeed = 200,
                    DoorCount = 4
             };
            vehicles.Add(motorCycle);
            Helicopter helicopter= new Helicopter()
            {
                Speed = 350,
                Acceleration = 250,
                BreakSpeed = 100,
                DoorCount = 3
            };
            vehicles.Add(helicopter);


            Console.WriteLine("Welches Fahrzeug möchtest du fahren?");

            var userInput = Console.ReadLine();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.GetType().Name == userInput)
                {
                    Console.WriteLine("Fahrzeug gefunden: " + userInput);

                    if (userInput == "Car")
                    {
                        Car c = vehicle as Car;
                        c.Move();
                    }
                    else if (userInput == "Plane")
                    {
                        Plane p =  vehicle as Plane;
                        p.Move();
                        p.Landing();
                    }
                    else if (userInput == "MotorCycle")
                    {
                        MotorCycle m = vehicle as MotorCycle;
                        m.Move();
                    }
                    else if (userInput == "MotorCycle")
                    {
                        Helicopter h = vehicle as Helicopter;
                        h.Move();
                        h.Landing();
                    }
                    else 
                    { 
                        Console.WriteLine("Steht nicht bereit!");
                        break;
                    }
                    vehicle.LogInformation();
                    break;
                    
                }
                else {
                    Console.WriteLine();
                }
            }
        }
    }
}
