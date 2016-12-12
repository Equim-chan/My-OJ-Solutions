// P1773 质因数
// https://vijos.org/p/1773
// by Equim on 15-12-14

#include<stdio.h>
int main()
{
	unsigned long n,i;
	scanf("%lu",&n);
	for(i=2;i<=n/2;i++)
		if(n%i==0)
		{
			printf("%lu",n/i);
			return 0;
		}
}
