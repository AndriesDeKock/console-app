using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;
using Xunit;

namespace ConsolApp.Tests
{
    public class ConsoleTests
    {
        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(5, 9, -4)]
        [InlineData(5, 1.3, 3.7)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Subtract_SimpleValueShouldCalculate(double x, double y, double expected) {

            // Arrange

            // Act
            double actual = ConsoleValidator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
