using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WeirdCase
{


    public string ToWeirdCase(string s)
    {
        var stringList = s.ToList();
        var stringBuilder = new StringBuilder();
        var charsOfThisIndex = new List<char>();
        var numberOfAppearances = 0;
        var indicesOfThisChar = new List<int>();


        foreach (var ch in stringList)
        {
            //charsOfThisIndex.Add(stringList[stringList.IndexOf(c)]);
            charsOfThisIndex = stringList.FindAll(character => character.Equals(ch));
            numberOfAppearances = charsOfThisIndex.Count();

            if (ch.ToString().Equals(" "))
            {
                stringBuilder.Append(ch);
            }

            if (numberOfAppearances > 1 && ch.ToString() != " ")
            {
                var duplicates = stringList.Select((t, i) => new { Index = i, Text = t }).Where(t => t.Text.Equals(ch))
                    .GroupBy(g => g.Text).Where(g => g.Count() > 1);

                foreach (var letterGroup in duplicates)
                {
                    foreach (var currentLetter in letterGroup)
                    {
                        if (currentLetter.Index == stringList.IndexOf(ch))
                        {
                            stringBuilder.Append(currentLetter.Index % 2 == 0 ? currentLetter.Text.ToString().ToUpper() : currentLetter.Text.ToString().ToLower());
                        }
                    }
                }



                //foreach (var letterGroup in duplicates)
                //{
                //    var currentLetter = duplicates.GetEnumerator().Current.GetEnumerator().Current;
                //    stringBuilder.Append(currentLetter.Index % 2 == 0 ? currentLetter.Text.ToString().ToUpper() : currentLetter.Text.ToString().ToLower());
                //}
            }

            stringBuilder.Append(stringList.IndexOf(ch) % 2 == 0 ? ch.ToString().ToUpper() : ch.ToString().ToLower());


            //var result = stringList
            //    .Select((c, i) => new { c, i })
            //    .Where(x => x.c == ch)
            //    .Skip(1)
            //    .FirstOrDefault();
            //    }

            //return result != null ? result.i : -1;
            //        
            //indicesOfThisChar.Add(c);

            //if (numberOfAppearances > 1)
            //{
            //    foreach (var charOfThisIndex in charsOfThisIndex)
            //    {
            //        //stringBuilder.Append(stringList.IndexOf(charOfThisIndex,
            //        //    charsOfThisIndex.IndexOf(charOfThisIndex) % 2 == 0 ? charOfThisIndex.ToString().ToUpper() : charOfThisIndex.ToString().ToLower()));


            //        //stringBuilder.Append(charsOfThisIndex.IndexOf(charOfThisIndex) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());

            //    }
            //}


            //if (numberOfAppearances > 1)
            //{
            //    foreach (var charOfThisIndex in charsOfThisIndex)
            //    {

            //    }
            //}




            //}

        }

        return stringBuilder.ToString();
    }
}