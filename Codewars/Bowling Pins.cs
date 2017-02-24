// Bowling Pins
// https://www.codewars.com/kata/bowling-pins/
// by Equim on 17-02-24

namespace BowlingPins {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class Bowling
    {
        public string BowlingPins(int[] arr)
        {
            if (arr.Length == 0)
               return "I I I I\n I I I \n  I I  \n   I   ";
            Array.Sort(arr);
            StringBuilder[] builder = new String[] { "", " ", "  ", "   " }.Select(p => new StringBuilder(p)).ToArray();
            for (int i = 1; i <= 10; i++)
            {
                int line = i >= 7 ? 0 : i >= 4 ? 1 : i >= 2 ? 2 : 3;
                builder[line].Append(Array.Exists(arr, p => p == i) ? "  " : "I ");
            }
            return String.Join("\n", builder.Select(p => p.ToString().TrimEnd().PadRight(7, ' ')));
        }
    }
}