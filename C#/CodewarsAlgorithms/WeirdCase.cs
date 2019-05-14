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
        

        foreach (var c in stringList)
        {
            //charsOfThisIndex.Add(stringList[stringList.IndexOf(c)]);
            charsOfThisIndex = stringList.FindAll(character => character.Equals(c));
            numberOfAppearances = charsOfThisIndex.Count();
            if (numberOfAppearances > 1)
            {
                foreach (var charOfThisIndex in charsOfThisIndex)
                {
                    stringBuilder.Append(charsOfThisIndex.IndexOf(charOfThisIndex) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());

                }
            }
            

            stringBuilder.Append(stringList.IndexOf(c) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());

        }

        return stringBuilder.ToString();
    }
}