// Find the odd int
// https://www.codewars.com/kata/find-the-odd-int
// by Equim on 16-12-13

function findOdd(A) 
{
    var sorted = A.sort();
    var begin = 0;
    for (var end in sorted)
    {
        if (sorted[end] != sorted[begin])
        {
            if ((end - begin) % 2 == 1)
                return sorted[begin];
            else
                begin = end;
        }
    }
    return sorted[begin];
}
