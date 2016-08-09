using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveSum
{
    public class Consecutive
    {
        public IList<int> ConsecutiveSum(IList<int> nums)
        {
            var prev = nums.First();
            var sum = prev;
            var res = new List<int>();
            nums = nums.Skip(1).ToList();

            foreach (var n in nums)
            {
                if (n != prev)
                {
                    prev = n;
                    res.Add(sum);
                    sum = n;
                }
                else
                {
                    sum += n;
                }
            }

            return res;
        }
    }
}