using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Katas.Tests
{
    public class MovingShiftTests
    {
        private CaesarShift _sut;

        public MovingShiftTests()
        {
            _sut = new CaesarShift();
        }

        [Theory]
        [InlineData("a", 2, new[] { "c", "", "", "", "" })]
        [InlineData("e", 1, new[] { "f", "", "", "", "" })]
        public void ShiftOneLetter_ReturnsShiftedLetter(string s, int shift, string[] res)
        {
            var actual = _sut.MovingShift(s, shift);
            var expected = res.ToList();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ab", 2, new[] { "c", "e", "", "", "" })]
        [InlineData("ef", 1, new[] { "f", "h", "", "", "" })]
        public void TwoLettersShift_ReturnsTwoSplitShiftedLetters(string s, int shift, string[] res)
        {
            var actual = _sut.MovingShift(s, shift);
            var expected = res.ToList();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", 2, new[] { "c", "e", "g", "", "" })]
        [InlineData("efg", 1, new[] { "f", "h", "j", "", "" })]
        public void ThreeLettersShift_ReturnsThreeSplitShiftedLetters(string s, int shift, string[] res)
        {
            var actual = _sut.MovingShift(s, shift);
            var expected = res.ToList();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcdef", 1, new[] { "bd", "fh", "jl", "", "" })]
        [InlineData("aaaaaa", 1, new[] { "bc", "de", "fg", "", })]
        public void SixLetters_ReturnsThreeSplitsOfTwoAndAnEmptySplit(string s, int shift, string[] res)
        {
            var actual = _sut.MovingShift(s, shift);
            var expected = res.ToList();

            Assert.Equal(expected, actual);
        }
    }
}