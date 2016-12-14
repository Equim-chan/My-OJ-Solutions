// Valid Parentheses
// https://www.codewars.com/kata/valid-parentheses/
// by Equim on 16-12-14

function validParentheses(parens)
{
    var ptn = [];
    for(var i = 0;i < parens.length;i++)
    {
        if (parens.charAt(i) == '(')
            ptn.push('(');
        else if (ptn.length == 0)
            return false;
        else
            ptn.pop();
    }
    return ptn.length == 0;
}
