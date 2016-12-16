// Sum Strings as Numbers
// https://www.codewars.com/kata/sum-strings-as-numbers/
// by Equim on 16-12-16

using System;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (b.Length > a.Length)
        {
            string t = a;
            a = b;
            b = t;
        }
        b = b.PadLeft(a.Length, '0');
        
        string rtn = null;
        int plus = 0;
        
        for(int i = b.Length - 1;i >= 0;i--)
        {
            int result = int.Parse(a.Substring(i, 1)) + int.Parse(b.Substring(i, 1)) + plus;
            
            plus = result / 10;
            result %= 10;
            
            rtn = result.ToString() + rtn;
        }
        if (plus > 0)
            rtn = plus.ToString() + rtn;
        
        return rtn.TrimStart('0');
    }
}
