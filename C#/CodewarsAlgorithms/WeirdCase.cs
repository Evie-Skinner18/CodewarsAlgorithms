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
        

        foreach (var c in stringList)
        {
            charsOfThisIndex.Add(stringList[stringList.IndexOf(c)]);

            foreach (var character in charsOfThisIndex)
            {
                stringBuilder.Append(charsOfThisIndex.IndexOf(character) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());
            }
        }

        return stringBuilder.ToString();
    }
}