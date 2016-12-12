// P1484 ISBN号码
// https://vijos.org/p/1484
// by Equim

#include<stdio.h>
int main()
{
	char isbni[14];
	int isbn[9];
//	FILE *in=fopen("isbn.in","r"),*out=fopen("isbn.out","w");
	int i,p=0,tol=0,last;
//	fscanf(in,"%s",isbni);
	scanf("%s",isbni);
	for(i=0;i<=11;i++)
		if(isbni[i]!='-')
		{
			isbn[p]=isbni[i]-48;
			p++;
		}
	for(i=0;i<=8;i++)
		tol+=isbn[i]*(i+1);
	tol%=11;
	if(isbni[12]!='X')
		last=isbni[12]-48;
	else
		last=10;
	if(last==tol)
		printf("Right");
	else
	{
		if(tol==10)
			isbni[12]='X';
		else
			isbni[12]=tol+48;
		printf("%s",isbni);
	}
//	fclose(out);
	return 0;
}
