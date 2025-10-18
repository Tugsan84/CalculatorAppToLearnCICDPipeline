using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CalculatorAppToLearnCICDPipeline;
using NUnit.Framework;

namespace CalculatorAppToLearnCICDPipeline.Tests
{
    public class Test1
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
            Assert.Equals(5, result);
        }
    }
}
