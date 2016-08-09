using Mumbling;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mumblings.Tests
{
    public class EqualArrayTests
    {
        private EqualArray _sut;

        public EqualArrayTests()
        {
            _sut = new EqualArray();
        }

        [Theory, AutoData]
        public void EmptyArrayReturnsMinusOne()
        {
            var actual = _sut.EqualSides(new int[] { });
            Assert.Equal(-1, actual);
        }

        [Theory, AutoData]
        public void SingletonArrayReturnsZero(int num)
        {
            var actual = _sut.EqualSides(new int[] { num });
            Assert.Equal(0, actual);
        }

        [Fact]
        public void TwoMemberArray_ReturnsMinusOne()
        {
            var actual = _sut.EqualSides(new int[] { 1, 2 });
            Assert.Equal(-1, actual);
        }

        [Theory, AutoData]
        public void ThreeMemberArray_EdgesEqual_ReturnsOne(int Edges, int Center)
        {
            var actual = _sut.EqualSides(new int[] { Edges, Center, Edges });
            Assert.Equal(1, actual);
        }

        [Fact]
        public void ThreeMemberArray_EdgesNonEqual_ReturnsMinusOne()
        {
            var actual = _sut.EqualSides(new int[] { 1, 2, 3 });
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void FourArray_EdgesEqual_ReturnsOne()
        {
            var actual = _sut.EqualSides(new int[] { 1, 0, -1, 2 });
            Assert.Equal(1, actual);
        }
    }
}