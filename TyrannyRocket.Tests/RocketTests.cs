using System;
using System.Collections.Generic;
using System.Text;

namespace TyrannyRocket.Tests
{
    public class RocketTests
    {

        //Bränslet för en modul är dess massa delat med 3, avrundat nedåt, minus 2.
        [Theory]
        [InlineData(12,2)]
        [InlineData(14,2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CalculateFuelByMass_ReturnsExpected(int mass, int expected)
        {
            // Arrange
            var sut = new Rocket();

            // Act
            var actual = sut.CalculateFuelByMass(mass);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100756, 50346)]
        [InlineData(1969, 966)]
        [InlineData(14, 2)]
        public void CalculateFuelRequirements_ReturnsExpect(int mass, int expected)
        {
            // AAA
            // Arrange
            var sut = new Rocket();

            // Act
            var actual = sut.CalculateFuelRequirements(mass);

            // Assert
            Assert.Equal(expected,actual);

        }
    }
}
