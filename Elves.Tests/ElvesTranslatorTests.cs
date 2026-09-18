using System;
using System.Collections.Generic;
using System.Text;

namespace Elves.Tests
{
    public class ElvesTranslatorTests
    {
        [Theory]
        [InlineData("1", "11")]
        [InlineData("11", "21")]
        [InlineData("21", "1211")]
        [InlineData("1211", "111221")]
        [InlineData("111221", "312211")]
        public void Translate_ReturnsExpected(string input, string expected)
        {
            var sut = new ElfTranslator();

            var actual = sut.Translate(input);

            Assert.Equal(expected, actual);
        }
    }
}
