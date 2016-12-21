// 0031 Weight (天秤)
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0031
// by Equim on 16-12-21

using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string Raw;
        while ((Raw = Console.ReadLine()) != null)
        {
            string Bin = Convert.ToString(int.Parse(Raw), 2);
            string Out = "";
            
            for (int i = Bin.Length - 1; i >= 0; i--)
                if (Bin[i] == '1')
                    Out += Math.Pow(2, Bin.Length - 1 - i).ToString() + " ";
            
            Console.WriteLine(Out.Trim());
        }
    }
}