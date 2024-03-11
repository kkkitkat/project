
using Xunit;
using AiwProj;
using Assert = Xunit.Assert;


namespace AirProjTests
{


    namespace AirProjTests
    {
        public class FanIntensityTests
        {
            [Fact]
            public void IncreaseFanIntensity_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.IncreaseFanIntensity();

                // Assert
                Assert.Equal(6, ac.FanIntensity);
            }

            [Fact]
            public void IncreaseFanIntensity_MaxFanIntensityReached()
            {
                // Arrange
                var ac = new AirConditioner(20, 10);

                // Act
                ac.IncreaseFanIntensity();

                // Assert
                Assert.Equal(1, ac.FanIntensity);
            }

            [Fact]
            public void DecreaseFanIntensity_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.DecreaseFanIntensity();

                // Assert
                Assert.Equal(4, ac.FanIntensity);
            }

            [Fact]
            public void DecreaseFanIntensity_MinFanIntensityReached()
            {
                // Arrange
                var ac = new AirConditioner(20, 1);

                // Act
                ac.DecreaseFanIntensity();

                // Assert
                Assert.Equal(10, ac.FanIntensity);
            }

            [Fact]
            public void SetFanIntensity_Valid()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act
                ac.FanIntensity = 8;

                // Assert
                Assert.Equal(8, ac.FanIntensity);
            }

            [Fact]
            public void SetFanIntensity_OutOfRange()
            {
                // Arrange
                var ac = new AirConditioner(20, 5);

                // Act & Assert
                Assert.Throws<ArgumentOutOfRangeException>(() => ac.FanIntensity = 0);
                Assert.Throws<ArgumentOutOfRangeException>(() => ac.FanIntensity = 11);
            }
        }
    }

}
