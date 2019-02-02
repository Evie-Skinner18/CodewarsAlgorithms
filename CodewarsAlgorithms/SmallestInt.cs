using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{
    public class SmallestInt
    {
        public int FindSmallestInt(int[] args)
        {
            return args.Min();

        }
    }
}

/*
 * THE LONG WAY ROUND
 * 
 * public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      int small = args[0];
      foreach(int num in args) {
        if(small > num) {
          small = num;
        }
      }
      return small;
    }
}
*/