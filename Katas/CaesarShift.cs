using System.Collections.Generic;

namespace Katas
{
    public class CaesarShift
    {
        public List<string> MovingShift(string s, int shift)
        {
            var res = new List<string>();
            int partitionSize = s.Length / 3;
            if (partitionSize == 0) partitionSize = 1;
            var count = 0;
            var stringPartition = string.Empty;

            foreach (var c in s)
            {
                var curChar = ((char)(c + shift++)).ToString();
                if (count < partitionSize)
                {
                    stringPartition += curChar;
                    count++;
                }
                else
                {
                    res.Add(stringPartition);
                    stringPartition = curChar;
                    count = 1;
                }
            }
            res.Add(stringPartition);

            return res;
        }
    }
}