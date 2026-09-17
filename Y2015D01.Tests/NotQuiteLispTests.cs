using System;
using System.Collections.Generic;
using System.Text;

namespace NotQuiteLisp.Tests
{
    public class NotQuiteLispTests
    {
        // An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), means he should go down one floor.

        [Theory]
        [InlineData("(())", 0)]
        [InlineData("(((", 3)]
        [InlineData("))(((((", 3)]
        [InlineData(")))", -3)]
        [InlineData(") ))", -3)]
        [InlineData("", 0)]
        public void GetFloor_ReturnsCorrectFloor(string values, int expected)
        {
            // Arrange
            var sut = new Stairs();

            // Act
            var actual = sut.GetFloor(values);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
