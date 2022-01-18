using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {

        }


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = false)
        {
        
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;

        }



        public void MakeEngineNoise(string EngineNoise)

        {
        
            Console.WriteLine(EngineNoise);

        }

    public void MakeHonkNoise(string HonkNoise)
       {
        
            Console.WriteLine(HonkNoise);
        
        }
}
}
