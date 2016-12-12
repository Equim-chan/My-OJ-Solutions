// P1756 数字反转
// https://vijos.org/p/1756
// by Equim on 15-12-15

#include<stdio.h>
#include<string.h>
int main()
{
	char N[20],*p=N;
	int flag=1;
	gets(N);
	if(N[0]=='-')
		printf("-");
	strrev(N);
	while(flag)
	{
		if(*p!='0')
			flag=0;
		else
			p++;
	}
	while(*p!='\0')
	{
		if(*p!='-')
			printf("%c",*p);
		p++;
	}
	return 0;
}
