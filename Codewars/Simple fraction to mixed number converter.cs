// Simple fraction to mixed number converter
// https://www.codewars.com/kata/simple-fraction-to-mixed-number-converter/
// by Equim on 16-12-12

using System;

public class Kata
{
    public static string MixedFraction(string s)
    {
        int[] Frc = Array.ConvertAll(s.Split('/'), p => int.Parse(p));

        string rtn = null;
        int i = 2;

        if (Frc[1] == 0)
            throw new DivideByZeroException();

        if (Frc[0] == 0)
            return "0";

        if (Frc[0] % Frc[1] == 0)
            return (Frc[0] / Frc[1]).ToString();

        // Well, there is a reason why not use '/'
        if (Frc[0] < 0 && Frc[1] > 0 || Frc[0] > 0 && Frc[1] < 0)
        {
            rtn += "-";
        }

        Frc[0] = Math.Abs(Frc[0]);
        Frc[1] = Math.Abs(Frc[1]);

        while (i < (Frc[0] > Frc[1] ? Frc[0] : Frc[1]) / 2)
        {
            if (Frc[0] % i == 0 && Frc[1] % i == 0)
            {
                Frc[0] /= i;
                Frc[1] /= i;
            }
            else
                i++;
        }

        if (Frc[0] / Frc[1] > 0)
            rtn += (Frc[0] / Frc[1]) + " " + (Frc[0] % Frc[1]);
        else
            rtn += Frc[0];

        return rtn + "/" + Frc[1];
    }
}
