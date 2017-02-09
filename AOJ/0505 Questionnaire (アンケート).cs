// 0505 Questionnaire (アンケート)
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0505
// by Equim on 17-02-08

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var Size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (Size[0] == 0) break;

            var Count = new Dictionary<int, int>();

            for (int i = 0; i < Size[0]; i++)
            {
                var Line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < Size[1]; j++)
                {
                    Count[j + 1] = (Count.ContainsKey(j + 1) ? Count[j + 1] : 0) + Line[j];
                }
            }
            
            Console.WriteLine(string.Join(" ", Count.OrderByDescending(p => p.Value).Select(p => p.Key.ToString()).ToArray()));
        }
    }
}
