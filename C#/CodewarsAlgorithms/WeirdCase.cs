using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WeirdCase
{


    public string ToWeirdCase(string s)
    {
        var stringList = s.Split(' ').ToList();
        var stringBuilder = new StringBuilder();
        var charsOfThisIndex = new List<char>();
        var numberOfAppearances = 0;
        var indicesOfThisChar = new List<int>();
        var wordList = new List<char>();


        foreach (var word in stringList)
        {
            wordList = word.ToList();

            foreach (var ch in wordList)
            {
                charsOfThisIndex = wordList.FindAll(character => character.Equals(ch));
                numberOfAppearances = charsOfThisIndex.Count();

               if (numberOfAppearances > 1)
                {
                    var duplicates = wordList.Select((t, i) => new { Index = i, Text = t }).Where(t => t.Text.Equals(ch))
                        .GroupBy(g => g.Text).Where(g => g.Count() > 1);

                    foreach (var letterGroup in duplicates)
                    {
                        foreach (var currentLetter in letterGroup)
                        {
                            if (currentLetter.Index % 2 == 0 && wordList.IndexOf(ch) % 2 == 0)
                            {
                                stringBuilder.Append(currentLetter.Text.ToString().ToUpper());
                            }

                            stringBuilder.Append(currentLetter.Text.ToString().ToLower());
                        }
                    }
                }

                stringBuilder.Append(wordList.IndexOf(ch) % 2 == 0 ? ch.ToString().ToUpper() : ch.ToString().ToLower());
            }

            stringBuilder.Append(" ");
        }

        return stringBuilder.ToString();
    }
}