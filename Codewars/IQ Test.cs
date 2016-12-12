// IQ Test
// https://www.codewars.com/kata/552c028c030765286c00007d
// by Equim
using System;
using System.Collections.Generic;
using System.Linq;

public class IQ
{
    public static int Test(string numbers)
    { 
         List<int> n = Array.ConvertAll<string, int>(numbers.Split(' '), s => int.Parse(s)).ToList();
         return n.Count(p => p%2==0) == 1 ? n.FindIndex(u => u%2==0) + 1 : n.FindIndex(u => u%2==1) + 1;
    }
}
