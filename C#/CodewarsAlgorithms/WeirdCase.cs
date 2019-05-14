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
        

        //foreach (var ch in stringList)
        //{
        //    //charsOfThisIndex.Add(stringList[stringList.IndexOf(c)]);
        //    charsOfThisIndex = stringList.FindAll(character => character.Equals(ch));
        //    numberOfAppearances = charsOfThisIndex.Count();

        //    if (numberOfAppearances > 1)
        //    {
        //        var n = stringList.IndexOf(ch);
        //        var result = stringList
        //            .Select((c, i) => new { c, i })
        //            .Where(x => x.c == ch)
        //            .Skip(1)
        //            .FirstOrDefault();


        //         //return result != null ? result.i : -1;
        //        stringBuilder.Append(result.i % 2 == 0 ? result.c.ToString().ToUpper() : result.c.ToString().ToLower());
        //    }
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

           // stringBuilder.Append(stringList.IndexOf(c) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());

            //if (numberOfAppearances > 1)
            //{
            //    foreach (var charOfThisIndex in charsOfThisIndex)
            //    {
            //        stringBuilder.Append(charsOfThisIndex.IndexOf(charOfThisIndex) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());

            //    }
            //}



        //}

        return stringBuilder.ToString();
    }
}