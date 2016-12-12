// Clock in Mirror
// https://www.codewars.com/kata/clock-in-mirror
// by Equim on 16-12-12

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string WhatIsTheTime(string timeInMirror)
    {
        var HM = Array.ConvertAll<string, int>(timeInMirror.Split(':'), s => int.Parse(s));
        HM[1] = (60 - HM[1]) % 60;
        HM[0] = 11 - HM[0] % 12;
        if (HM[1] == 0) HM[0]++;
        if (HM[0] == 0) HM[0] = 12;

        return HM[0].ToString("D2") + ":" + HM[1].ToString("D2");
    }
}
