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
            var nums = Int32.Parse(numbers);
            int[] ints = nums
            char[] characters = numbers.ToCharArray();
            

            foreach(char c in characters)
            {
               if( c != '')
                {
                    var number = Char.GetNumericValue(c);
                }
            }
            return "throw towel";
        }
    }
}
