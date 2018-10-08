using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{
    public class GetTheMiddleCharacter
    {
        public string GetMiddle(string s)
        {
            //var letters = s.ToCharArray();
            int middle = s.Length / 2;

            if (s.Length % 2 == 0)
            {
                return s[s.Length / 2 - 1] + s[s.Length / 2];
            }
            else
            {
                return s[s.Length / 2];
            }
                    // if odd, rtn the char at index letters.Length / 2.
            
    }
}
