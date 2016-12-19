// 1029: Palindrome
// http://acm.csu.edu.cn/OnlineJudge/problem.php?id=1029
// by Equim on 16-04-15

#include<iostream>
#include<string>
#include<algorithm>
using namespace std;
int main()
{
	int total;
	cin>>total;
	for(int i=1;i<=total;i++)
	{
		string original;
		cin>>original;
		string reversed(original);
		reverse(reversed.begin(),reversed.end());
		if(original == reversed)
			cout<<"YES\n"; 
		else
			cout<<"NO\n";
	}
	return 0;
}
