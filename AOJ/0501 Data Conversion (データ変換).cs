// 0501 Data Conversion (データ変換)
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0501
// by Equim on 16-12-20

using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int Total;

        while ((Total = int.Parse(Console.ReadLine())) != 0)
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();

            for (int t = 1; t <= Total; t++)
            {
                string[] Raw = Console.ReadLine().Split(' ');
                Dict.Add(Raw[0], Raw[1]);
            }

            Total = int.Parse(Console.ReadLine());

            for (int t = 1; t <= Total; t++)
            {
                string Raw = Console.ReadLine();

                if (Dict.ContainsKey(Raw))
                    Console.Write(Dict[Raw]);
                else
                    Console.Write(Raw);
            }
            Console.WriteLine();
        }
    }
}