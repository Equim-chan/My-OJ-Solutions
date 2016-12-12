// 394. Decode String
// https://leetcode.com/problems/decode-string/
// by Equim

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string DecodeString(string s)
    {
        Stack<int> PosStack = new Stack<int>();

        for (int i = 0; i < s.Length; i++)
        {
            // if (Char.IsNumber(s[i]))
            if (s[i] == '[')
            {
                PosStack.Push(i);
            }
            if (s[i] == ']')
            {
                int Begin = PosStack.Pop();
                string TargetString = s.Substring(Begin + 1, i - 1 - Begin);        //要加倍的字符串
                string StringToReplace = TargetString;                              //加倍好的字符串

                // 确定重复次数
                int NumberBeginAt = Begin - 1;
                while (!(NumberBeginAt == 0 || !Char.IsNumber(s[NumberBeginAt - 1])))
                {
                    NumberBeginAt--;
                }
                int Repeat = int.Parse(s.Substring(NumberBeginAt, Begin - NumberBeginAt));

                // 重复字符串
                for (int j = 1; j < Repeat; j++)
                {
                    StringToReplace += TargetString;
                }
                
                // 塞进去
                s = s.Substring(0, NumberBeginAt) + StringToReplace + (i < s.Length - 1 ? s.Substring(i + 1) : null);

                // 之前忘了这个，结果几次出现栈空异常
                if (PosStack.Count > 0)
                    i = PosStack.Peek() + 1;
                else
                    i = 0;
                    
                // 时间复杂度有点高其实
            }
        }
        return s;
    }
}

/*
public class Program
{
    public static void Main(string[] args)
    {
        //string Case = "2[aWz3[Equi2[Me]]d]";
        //string Case = "2[2[2[b]]]";
        //string Case = "2[a]3[b]4[c]5[d]";
        string Case = "3[ABC]100[l2[EQ]eetcode]";
        Console.WriteLine(new Solution().DecodeString(Case));
    }
}
*/
