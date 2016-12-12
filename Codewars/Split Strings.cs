// Split Strings
// https://www.codewars.com/kata/split-strings
// by Equim on 16-12-12

using System.Collections.Generic;
using System.Linq;

public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 == 1)
            str += "_";

        List<string> rtn = new List<string>();

        for (int i = 0; i < str.Length; i += 2)
        {
            var a = str.Substring(i, 2);
            System.Console.WriteLine(a);
            rtn.Add(a);
        }
        return rtn.ToArray();
    }
}
