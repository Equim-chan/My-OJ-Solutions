// 2644 Longest Match
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=2644
// by Equim on 16-12-20

using System;

class Program
{
    public static int Process(ref string S)
    {
        string[] Raw = Console.ReadLine().Split(' ');
        string x = Raw[0];
        string y = Raw[1];

        int BeginAt = S.IndexOf(x);
        if (BeginAt == -1) return 0;

        int EndAt = S.LastIndexOf(y);
        if (EndAt == -1 || EndAt < BeginAt) return 0;

        int RejudgePoint = x.LastIndexOf(y);
        if (EndAt - BeginAt < x.Length && RejudgePoint != -1 && RejudgePoint != x.Length - y.Length) return 0;

        return EndAt - BeginAt + y.Length;
    }

    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
        int Cases = int.Parse(Console.ReadLine());

        for (int t = 1; t <= Cases; t++)
            Console.WriteLine(Process(ref S));
    }
}