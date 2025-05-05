using System;
using Xunit;
using PercentageLibrary;

namespace PercentageLibrary.Tests
{
    public class PercentageCalculatorTests
    {
        [Theory]
        [InlineData(200, 10, 20)]
        [InlineData(150, 25, 37.5)]
        [InlineData(0, 50, 0)]
        public void CalculatePercentOf_ValidInputs_ReturnsCorrectResult(double value, double percent, double expected)
        {
            double result = PercentageCalculator.CalculatePercentOf(value, percent);
            Assert.Equal(expected, result, 2);
        }

        [Theory]
        [InlineData(double.NaN, 10)]
        [InlineData(100, double.NaN)]
        public void CalculatePercentOf_InvalidInputs_ThrowsArgumentException(double value, double percent)
        {
            Assert.Throws<ArgumentException>(() => PercentageCalculator.CalculatePercentOf(value, percent));
        }

        [Theory]
        [InlineData(30, 10, 300)]
        [InlineData(25, 50, 50)]
        public void FindBaseFromPercent_ValidInputs_ReturnsCorrectResult(double percentValue, double percent, double expected)
        {
            double result = PercentageCalculator.FindBaseFromPercent(percentValue, percent);
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void FindBaseFromPercent_ZeroPercent_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => PercentageCalculator.FindBaseFromPercent(50, 0));
        }

        [Theory]
        [InlineData(double.NaN, 20)]
        [InlineData(50, double.NaN)]
        public void FindBaseFromPercent_InvalidInputs_ThrowsArgumentException(double percentValue, double percent)
        {
            Assert.Throws<ArgumentException>(() => PercentageCalculator.FindBaseFromPercent(percentValue, percent));
        }
    }
}
