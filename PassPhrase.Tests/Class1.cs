using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PassPhrase.Tests
{
    public class Class1
    {
        private PassyPhrase _sut;

        public Class1()
        {
            _sut = new PassyPhrase();
        }

        [Fact]
        public void SingleCharacter_Play_ReturnsShiftedLetter()
        {
            var actual = _sut.playPass("C", 1);
            Assert.Equal("D", actual);
        }
    }
}