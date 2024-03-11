

using AiwProj;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AirProjTests
{
    [TestFixture]
    public class FanIntensityTests
    {

        [Test]
        public void IncreaseFanIntensity_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.IncreaseFanIntensity();

            // Assert
            Assert.AreEqual(6, ac.FanIntensity);
        }

        [Test]
        public void IncreaseFanIntensity_MaxFanIntensityReached()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 10);

            // Act
            ac.IncreaseFanIntensity();

            // Assert
            Assert.AreEqual(1, ac.FanIntensity);
        }

        [Test]
        public void DecreaseFanIntensity_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.DecreaseFanIntensity();

            // Assert
            Assert.AreEqual(4, ac.FanIntensity);
        }

        [Test]
        public void DecreaseFanIntensity_MinFanIntensityReached()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 1);

            // Act
            ac.DecreaseFanIntensity();

            // Assert
            Assert.AreEqual(10, ac.FanIntensity);
        }

        [Test]
        public void SetFanIntensity_Valid()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act
            ac.FanIntensity = 8;

            // Assert
            Assert.AreEqual(8, ac.FanIntensity);
        }

        [Test]
        public void SetFanIntensity_OutOfRange()
        {
            // Arrange
            AirConditioner ac = new AirConditioner(20, 5);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ac.FanIntensity = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ac.FanIntensity = 11);
        }
    }
}
