using System;
namespace CodewarsAlgorithms
{
    public class HighestScoringWord
    {
        public static string CalculateHighestScoringWord(string s)
        {
            var listOfWords = s.Substring(" ").ToList();
            var score = 0;

            foreach (var word in listOfWords)
            {
                //var listOfChars = word.ToList<char>();
                score = word.Contains('a') ? score + 1 : score;


            }

        }
    }
}
