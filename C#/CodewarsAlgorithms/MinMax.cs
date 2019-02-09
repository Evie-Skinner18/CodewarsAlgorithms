using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsAlgorithms
{
    public class GetMinAndMax
    {
        public int[] MinMax(int[] lst)
        {
            var listOfNums = lst.ToList();
            var min = listOfNums.Min();
            var max = listOfNums.Max();

            var minAndMax = new List<int>
            {
                min,
                max
            };
            return minAndMax.ToArray();
        }
    }
}
