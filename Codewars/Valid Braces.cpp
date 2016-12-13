// Valid Braces
// https://www.codewars.com/kata/valid-braces/
// by Equim on 16-12-14

#include <map>
#include <stack>

using namespace std;
bool valid_braces(string braces)
{
    map<char, char> KDict;
    KDict['('] = ')';
    KDict['['] = ']';
    KDict['{'] = '}';
    
    stack<char> K;

    for (int i = 0;i < braces.length();i++)
    {
        if (braces[i] == '(' || braces[i] == '[' || braces[i] == '{')
            K.push(braces[i]);
        else if (K.empty())
            return false;
        else
        {
            char current = K.top();
            K.pop();
            if (KDict[current] != braces[i])
                return false;
        }
    }
    return K.empty();
}
