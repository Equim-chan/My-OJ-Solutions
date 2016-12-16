// Large Factorials
// https://www.codewars.com/kata/large-factorials/
// by Equim on 16-12-16

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Factorial(int n)
    {
        if (n == 0) return "1";
        if (n < 0) return null;

        if (n <= 20)
        {
            // In the range of ulong
            ulong rtn = 1;

            for (int i = 1; i <= n; i++)
                rtn *= (ulong)i;
            return rtn.ToString();
        }
        // Out of the range of ulong
        List<int> result = "2432902008176640000".Reverse().ToList().ConvertAll<int>(s => int.Parse(s.ToString()));     // 20!

        for (int i = 21; i <= n; i++)
        {
            result = result.Select(p => p *= i).ToList();

            // O(n^2), for safe.
            for (int j = 0; j < result.Count; j++)
            {
                if (result[j] >= 10)
                {
                    if (j >= result.Count - 1)
                        result.Add(result[j] / 10);
                    else
                        result[j + 1] += result[j] / 10;
                    result[j] %= 10;
                }
            }
        }
        return result.Select(p => p.ToString()).Aggregate((a, b) => b + a);
    }
}
