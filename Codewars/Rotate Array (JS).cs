// Rotate Array (JS)
// https://www.codewars.com/kata/rotate-array-js/
// by Equim on 16-12-12

public class Kata
{
    public static object[] Rotate(object[] array, int n)
    {
        object[] rtn = new object[array.Length];
        n %= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            int index = i - n;

            if (index < 0)
                index += array.Length;
            if (index >= array.Length)
                index -= array.Length;
            rtn[i] = array[index];
        }

        return rtn;
    }
}
