using System;
using Xunit;
using BhaskaraApp; // Referência ao projeto BhaskaraApp

namespace BhaskaraTests
{
    public class BhaskaraTests
    {
        [Fact]
        public void TestRaizesDuas()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2;

            // Act
            var raizes = Bhaskara.CalcularRaizes(a, b, c);

            // Assert
            Assert.Equal(2, raizes.Length);
            Assert.Contains(1, raizes);
            Assert.Contains(2, raizes);
        }

        [Fact]
        public void TestRaizesNenhuma()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 5;

            // Act
            var raizes = Bhaskara.CalcularRaizes(a, b, c);

            // Assert
            Assert.Empty(raizes);
        }
    }
}
