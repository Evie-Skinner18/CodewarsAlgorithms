using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{
    public class HighestAndLowest
    {
        public string HighAndLow(string numbers)
        {
            // Code here or
            //var nums = Int32.Parse(numbers);
            //int[] ints = nums;
            //int oneLongInt = Int32.Parse(numbers);
            //int[] intNums = oneLongInt.

            string[] stringNums = numbers.Split(' ');


            foreach (string stringNum in stringNums)
            {
                Int32.Parse(stringNum);
            }
            return "throw towel";
        }
    }
}
