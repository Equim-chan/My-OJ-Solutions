// Sort the odd
// https://www.codewars.com/kata/sort-the-odd/
// by Equim on 16-12-13

using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        var sorted = array.Where(p => p % 2 == 1).OrderBy(p => p).ToArray();

        int i = 0;

        for (int j = 0; j < array.Length; j++)
        {
            array[j] = array[j] % 2 == 1 ? sorted[i++] : array[j];
        }

        return array;
    }
}
