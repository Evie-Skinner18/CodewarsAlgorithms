using System.Linq;
using System.Text;

public class WeirdCase
{


    public string ToWeirdCase(string s)
    {
        var stringList = s.ToList();
        var stringBuilder = new StringBuilder();

        foreach (var c in stringList)
        {
            stringBuilder.Append(stringList.IndexOf(c) % 2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower());
        }

        return stringBuilder.ToString();
    }
}