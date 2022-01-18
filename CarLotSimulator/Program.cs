using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Car Toyota = new Car();
            Toyota.Make = "toyota";
            Toyota.Model = "camry";
            Toyota.Year = 2013;
            Toyota.EngineNoise = "vrum";
            Toyota.HonkNoise = "beep";
            Toyota.IsDriveable = true;

            Console.WriteLine("Toyota");
            Toyota.MakeEngineNoise(Toyota.EngineNoise);
            Toyota.MakeHonkNoise(Toyota.HonkNoise);

            Car Sierra = new Car() { Make = "Chevy", Model = "GMC", Year = 2015, EngineNoise = "grrr", HonkNoise = "beap", IsDriveable = true };

            Console.WriteLine("Sierra:");
            Sierra.MakeEngineNoise(Sierra.EngineNoise);
            Sierra.MakeHonkNoise(Sierra.HonkNoise);

            Car Civic = new Car( 2015, "Capris","Honda" , "ruuu", "Beat", true);

            Console.WriteLine("Civic:");
            Civic.MakeEngineNoise(Civic.EngineNoise);
            Civic.MakeHonkNoise(Civic.HonkNoise);

            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}.");

            

         
        }
    }
}
