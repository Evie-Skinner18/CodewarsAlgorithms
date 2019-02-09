using System;
using System.Linq;
using System.Collections.Generic;

namespace CodewarsAlgorithms
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            // recursive method

            var listOfN = n.ToString();
            var cList = listOfN.ToList();
            int digitalRoot = 0;

            foreach (var c in cList)
            {
                digitalRoot = digitalRoot + Int32.Parse(c.ToString());
            }

            if (digitalRoot >= 10)
            {
                digitalRoot = DigitalRoot(digitalRoot);
            }

            return digitalRoot;

        }
    }
}
