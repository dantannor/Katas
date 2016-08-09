using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsecutiveSum.Tests
{
    public class ConsecutiveSumTests
    {
        private Consecutive _sut;

        public ConsecutiveSumTests()
        {
            _sut = new Consecutive();
        }

        [Theory, AutoData]
        public void ListOfSameNumbers_ReturnsSum(Generator<int> generator, int count)
        {
            var num = generator.Take(1).ToArray().First();
            var nums = Enumerable.Repeat(num, count).ToList();

            var actual = _sut.ConsecutiveSum(nums);
            var expected = new List<int>() { nums.Sum() };

            Assert.Equal(expected, actual);
        }

        [Theory, AutoData]
        public void ListOfTwoConsecutives_ReturnsTwoSums(Generator<int> generator, int count1, int count2)
        {
            var num1 = generator.Take(1).First();
            var nums1 = Enumerable.Repeat(num1, count1);

            var num2 = generator.Where(n => n != num1).Take(1).First();
            var nums2 = Enumerable.Repeat(num2, count2);

            var nums = nums1.Concat(nums2).ToList();
            var actual = _sut.ConsecutiveSum(nums);
            var expected = new List<int>() { nums1.Sum(), nums2.Sum() };

            Assert.Equal(expected, actual);
        }
    }
}