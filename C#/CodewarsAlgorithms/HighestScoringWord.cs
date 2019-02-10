using System;
using System.Linq;
using System.Collections.Generic;

namespace CodewarsAlgorithms
{
    public static class HighestScoringWord
    {
        public static string CalculateHighestScoringWord(string s)
        {
            var listOfWords = s.Split(' ').ToList();
            var score = 0;
            //var scoreBoard = new List<int>;
            var scoreBoard = new Dictionary<string, int>();

            string highestScoringWord;

            foreach (var word in listOfWords)
            {
                // Not very dry
                score = word.Contains('a') ? score + 1 : score;
                score = word.Contains('b') ? score + 2 : score;
                score = word.Contains('c') ? score + 3 : score;
                score = word.Contains('d') ? score + 4 : score;
                score = word.Contains('e') ? score + 5 : score;
                score = word.Contains('f') ? score + 6 : score;
                score = word.Contains('g') ? score + 7 : score;
                score = word.Contains('h') ? score + 8 : score;
                score = word.Contains('i') ? score + 9 : score;
                score = word.Contains('j') ? score + 10 : score;
                score = word.Contains('k') ? score + 11 : score;
                score = word.Contains('l') ? score + 12 : score;
                score = word.Contains('m') ? score + 13 : score;
                score = word.Contains('n') ? score + 14 : score;
                score = word.Contains('o') ? score + 15 : score;
                score = word.Contains('p') ? score + 16 : score;
                score = word.Contains('q') ? score + 17 : score;
                score = word.Contains('r') ? score + 18 : score;
                score = word.Contains('s') ? score + 19 : score;
                score = word.Contains('t') ? score + 20 : score;
                score = word.Contains('u') ? score + 21 : score;
                score = word.Contains('v') ? score + 22 : score;
                score = word.Contains('w') ? score + 23 : score;
                score = word.Contains('x') ? score + 24 : score;
                score = word.Contains('y') ? score + 25 : score;
                score = word.Contains('z') ? score + 26 : score;
                
                scoreBoard.Add(word, score);
                score = 0;
            }

            return highestScoringWord = scoreBoard.Max().Key;
        }
    }
}
