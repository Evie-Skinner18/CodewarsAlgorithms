using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{
    class GetTheMiddleCharacter
    {
        public string GetMiddle(string s)
        {
            string middle = "";
            var letters = s.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                letters.Length % 2 == 0? middle = 
                    // if odd, rtn the char at index letters.Length / 2.
            }
    }
}
