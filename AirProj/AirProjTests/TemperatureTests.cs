using AiwProj;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AirProjTests
{
    [TestFixture]
    public class TemperatureTests
    {
        [Test]
        public void IncreaseTemperature_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.IncreaseTemperature();

            // Assert
            Assert.AreEqual(21, ac.Temperature);
        }

        [Test]
        public void IncreaseTemperature_MaxTemperatureReached()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(30, 5);

            // Act
            ac.IncreaseTemperature();

            // Assert
            Assert.AreEqual(30, ac.Temperature);
        }

        [Test]
        public void DecreaseTemperature_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.DecreaseTemperature();

            // Assert
            Assert.AreEqual(19, ac.Temperature);
        }

        [Test]
        public void DecreaseTemperature_MinTemperatureReached()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(10, 5);

            // Act
            ac.DecreaseTemperature();

            // Assert
            Assert.AreEqual(10, ac.Temperature);
        }

        [Test]
        public void SetTemperature_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.Temperature = 25;

            // Assert
            Assert.AreEqual(25, ac.Temperature);
        }

        [Test]
        public void SetTemperature_OutOfRange()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ac.Temperature = 5);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ac.Temperature = 35);
        }
    }
}