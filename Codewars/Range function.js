// Range function
// https://www.codewars.com/kata/range-function/
// by Equim on 16-12-13

function range(a, b, c)
{
    var begin = 1;
    var end;
    var jump = 1;
    var rtn = new Array();
    
    if (arguments.length == 1)
    {
        end = a;
    }
    else if (arguments.length == 2)
    {
        begin = a;
        end = b;
    }
    else
    {
        begin = a;
        jump = b;
        end = c;
    }
    
    if (end < begin)
        return rtn;
    
    rtn[0] = begin;
    var i = 1;
    while(rtn[i-1] + jump <= end)
    {
        rtn[i] = rtn[i-1] + jump;
        i++;
    }
    return rtn;
}
