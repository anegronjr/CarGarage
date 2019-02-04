using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            var testGarage = new Garage();

            // Act
            testGarage.AddCar();

            // Assert
            Assert.NotEmpty(testGarage.Cars);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            var testGarage = new Garage();

            // Act
            testGarage.AddCar();
            testGarage.RemoveCar(0);

            // Assert
            Assert.Empty(testGarage.Cars);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var testGarage = new Garage();

            // Act
            testGarage.AddCar();
            testGarage.FuelAllCars();

            // Assert
            foreach (var car in testGarage.Cars)
            {
                Assert.Equal(100, car.GasLevel);
            }
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
