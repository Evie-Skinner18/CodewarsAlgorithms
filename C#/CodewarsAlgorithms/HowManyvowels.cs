using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsAlgorithms
{

        public class Kata
        {
            public int GetVowelCount(string str)
            {
                int vowelCount = 0;

                // Your code here
                char[] letters = str.ToLower().ToCharArray();

                foreach (char c in letters)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelCount++;
                    }
                }

                return vowelCount;
            }
        }

 }
