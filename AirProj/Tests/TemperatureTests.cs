using AiwProj;
using Xunit;
using Assert = Xunit.Assert;

namespace AirProjTests
{

    namespace AirProjTests
    {
        public class TemperatureTests
        {
            [Fact]
            public void IncreaseTemperature_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.IncreaseTemperature();

                // Assert
                Assert.Equal(21, ac.Temperature);
            }

            [Fact]
            public void IncreaseTemperature_MaxTemperatureReached()
            {
                // Arrange
                var ac = new AirConditioner(30, 5);

                // Act
                ac.IncreaseTemperature();

                // Assert
                Assert.Equal(30, ac.Temperature);
            }

            [Fact]
            public void DecreaseTemperature_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.DecreaseTemperature();

                // Assert
                Assert.Equal(19, ac.Temperature);
            }

            [Fact]
            public void DecreaseTemperature_MinTemperatureReached()
            {
                // Arrange
                var ac = new AirConditioner(10, 5);

                // Act
                ac.DecreaseTemperature();

                // Assert
                Assert.Equal(10, ac.Temperature);
            }

            [Fact]
            public void SetTemperature_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.Temperature = 25;

                // Assert
                Assert.Equal(25, ac.Temperature);
            }

            [Fact]
            public void SetTemperature_OutOfRange()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act & Assert
                Assert.Throws<ArgumentOutOfRangeException>(() => ac.Temperature = 5);
                Assert.Throws<ArgumentOutOfRangeException>(() => ac.Temperature = 35);
            }
        }
    }

}