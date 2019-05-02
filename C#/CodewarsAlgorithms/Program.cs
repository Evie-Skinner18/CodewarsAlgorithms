using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

          
            //Console.WriteLine(HighestScoringWord.CalculateHighestScoringWord("pip doggie flangella vinyl"));
            var weirdString = new WeirdCase();
            Console.WriteLine(weirdString.ToWeirdCase("nelly"));
            Console.ReadKey();

        }
    }
}
