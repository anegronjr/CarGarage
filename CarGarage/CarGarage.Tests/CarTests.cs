using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var testCar = new Car();

            // Act
            testCar.Accelerate();

            // Assert
            Assert.Equal(10, testCar.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            var testCar = new Car();

            // Act
            testCar.Accelerate();

            // Assert
            Assert.Equal(70, testCar.GasLevel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            var testCar = new Car();

            // Act
            testCar.AddFuel();

            // Assert
            Assert.Equal(100, testCar.GasLevel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var testCar = new Car(10, 100, false);

            // Act
            testCar.Brake();

            // Assert
            Assert.Equal(0, testCar.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            var testCar = new Car();

            // Act
            testCar.ToggleEngine();

            // Assert
            Assert.True(testCar.EngineStatus);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            var testCar = new Car(0, 100, true);

            // Act
            testCar.ToggleEngine();

            // Assert
            Assert.False(testCar.EngineStatus);
        }
    }
}
