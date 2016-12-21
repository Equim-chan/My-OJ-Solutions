// P1752 潜伏者
// https://vijos.org/p/1752
// by Equim on 16-12-22

#include <iostream>
#include <map>
#include <string>

using namespace std;
int main()
{
    string source, given, target;
    cin >> source >> given >> target;
    map<char, char> method;
    map<char, char> check;
    
    for (int i = 0; i < source.length(); i++)
    {
        if (method.count(source[i]) == 1 && method[source[i]] != given[i])
        {
            cout << "Failed" << endl;
            return 0;
        }
        if (check.count(given[i]) == 1 && check[given[i]] != source[i])
        {
            cout << "Failed" << endl;
            return 0;
        }
        method[source[i]] = given[i];
        check[given[i]] = source[i];
    }
    
    if (method.size() < 26)
    {
            cout << "Failed" << endl;
            return 0;
    }
    
    string solved = "";
    for (int i = 0; i < target.length(); i++)
    {
        solved += method[target[i]];
    }
    cout << solved << endl;
    
    return 0;
}