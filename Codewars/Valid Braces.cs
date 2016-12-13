// Valid Braces
// https://www.codewars.com/kata/valid-braces/
// by Equim on 16-12-14

using System.Collections.Generic;

public class Brace
{
    public static bool validBraces(string braces)
    {
        Dictionary<char, char> KDict = new Dictionary<char, char>()
        {
            {'(', ')'}, {'[', ']'}, {'{', '}'}
        };
        Stack<char> K = new Stack<char>();

        foreach (var item in braces.ToCharArray())
        {
            if (item == '(' || item == '[' || item == '{')
                K.Push(item);
            else if (K.Count == 0 || KDict[K.Pop()] != item)
                return false;
        }
        return K.Count == 0;
    }
}
