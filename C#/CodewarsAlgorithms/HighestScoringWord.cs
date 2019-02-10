using System;
using System.Linq;
using System.Collections.Generic;

namespace CodewarsAlgorithms
{
    public class HighestScoringWord
    {
        public static string CalculateHighestScoringWord(string s)
        {
            var listOfWords = s.Split(' ').ToList();
            //var listOfWords = arrayOfWords.t
            var score = 0;

            foreach (var word in listOfWords)
            {

                score = word.Contains('a') ? score + 1 : score;
                score = word.Contains('b') ? score + 1 : score;
                score = word.Contains('c') ? score + 1 : score;
                score = word.Contains('d') ? score + 1 : score;
                score = word.Contains('e') ? score + 1 : score;
                score = word.Contains('f') ? score + 1 : score;
                score = word.Contains('g') ? score + 1 : score;
                score = word.Contains('h') ? score + 1 : score;
                score = word.Contains('i') ? score + 1 : score;
                score = word.Contains('j') ? score + 1 : score;
                score = word.Contains('k') ? score + 1 : score;
                score = word.Contains('l') ? score + 1 : score;
                score = word.Contains('m') ? score + 1 : score;
                score = word.Contains('n') ? score + 1 : score;
                score = word.Contains('o') ? score + 1 : score;
                score = word.Contains('p') ? score + 1 : score;
                score = word.Contains('q') ? score + 1 : score;
                score = word.Contains('r') ? score + 1 : score;
                score = word.Contains('s') ? score + 1 : score;
                score = word.Contains('t') ? score + 1 : score;
                score = word.Contains('u') ? score + 1 : score;
                score = word.Contains('v') ? score + 1 : score;
                score = word.Contains('w') ? score + 1 : score;
                score = word.Contains('x') ? score + 1 : score;
                score = word.Contains('y') ? score + 1 : score;
                score = word.Contains('z') ? score + 1 : score;

            }

        }
    }
}
