using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    public class EqualArray
    {
        public int EqualSides(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum()) return i;
            }
            return -1;
        }
    }
}