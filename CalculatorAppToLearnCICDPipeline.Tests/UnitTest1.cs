using Xunit;
using CalculatorAppToLearnCICDPipeline;

namespace CalculatorAppToLearnCICDPipeline.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            int x = 5;
            int y = 7;

            // Act
            int result = Program.Add(x, y);

            // Assert
            Assert.Equal(13, result);
        }
    }
}
