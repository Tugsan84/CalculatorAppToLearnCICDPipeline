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
            int x = 3;
            int y = 2;

            // Act
            int result = Program.Add(x, y);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
