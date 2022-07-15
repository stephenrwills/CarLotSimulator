using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot1 = new Carlot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            // Dot Method
            var car1 = new Car();
            car1.Make = "Toyota";
            car1.Year = 2010;
            car1.Model = "Camry";
            car1.EngineNoise = "Concerning";
            car1.HonkNoise = "Faint Beep";
            car1.IsDriveable = true;
            lot1.Cars.Add(car1);


            // Object Initializer Syntax
            var car2 = new Car()
            {
                Year = 1993,
                Make = "Ford",
                Model = "Ranger",
                EngineNoise = "Stalling Out",
                HonkNoise = "Beep",
                IsDriveable = true

            };
            lot1.Cars.Add(car2);

            var car3 = new Car();
            car3.Make = "Hyundai";
            car3.Model = "Sonata";
            car3.Year = 2006;
            car3.EngineNoise = "low RPM rumble";
            car3.HonkNoise = "Beep Beep";
            car3.IsDriveable = true;
            lot1.Cars.Add(car3);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot1.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
                
            }

            Console.WriteLine(Carlot.NumberOfCars);
        }
    }
}
