// Valid Braces
// https://www.codewars.com/kata/valid-braces/
// by Equim on 16-12-14

function validBraces(braces)
{
    var KDict = { '(': ')', '[': ']', '{': '}' };
    var K = [];

    for (var i = 0;i < braces.length;i++)
    {
        if (braces.charAt(i) == '(' || braces.charAt(i) == '[' || braces.charAt(i) == '{')
            K.push(braces.charAt(i));
        else if (K.length == 0 || KDict[K.pop()] != braces.charAt(i))
            return false;
    }
    return K.length == 0;
}
