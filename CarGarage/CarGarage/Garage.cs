using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> Cars { get; private set; }

        public Garage()
        {
            Cars = new List<Car>();
        }

        public void AddCar()
        {
            var newCar = new Car();

            Cars.Add(newCar);
        }

        public void RemoveCar(int index)
        {
            Cars.RemoveAt(index);
        }

        public void FuelAllCars()
        {
            foreach (var car in Cars)
            {
                car.AddFuel();
            }
        }
    }
}
