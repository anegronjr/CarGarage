using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool EngineStatus { get; private set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }

        public Car()
        {
            Speed = 0;
            GasLevel = 75;
            EngineStatus = false;
        }

        //Overloaded constructor used exclusively for TDD testing.
        public Car(int testSpeed, int testGasLevel, bool testEngineStatus)
        {
            Speed = testSpeed;
            GasLevel = testGasLevel;
            EngineStatus = testEngineStatus;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 5;
        }

        public void AddFuel()
        {
            GasLevel = 100;
        }

        public void Brake()
        {
            Speed -= 10;
        }

        public void ToggleEngine()
        {
            if (EngineStatus)
            {
                EngineStatus = false;
            } else
            {
                EngineStatus = true;
            }
        }
    }
}
