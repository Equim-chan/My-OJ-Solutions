// P1131 最小公倍数和最大公约数问题
// https://vijos.org/p/1131
// by Equim on 15-12-14

#include<stdio.h>
long xO,yO;
int flag(long p,long q)
{
	long i=2,j=1,maxbei,minyue;
	if(q%p==0)
	{
		maxbei=q;
		minyue=p;
	}
	else
	{
		while(i<=p/2)
		{
			if((p%i==0)&&(q%i==0))
			{
				p/=i;
				q/=i;
				j*=i;
			}
			else
				i++;
		}
		maxbei=j*p*q;
		minyue=j;
	}
	if((minyue==xO)&&(maxbei==yO))
		return 1;
	else
		return 0;
}
int Cal()
{
	long p,q,limit=(xO+yO)/2;
	int n=0;
//	for(p=2*xO;p<=limit;p+=xO)
//		for(q=3*xO;q<=yO;q+=xO)
	for(p=xO;p<=yO;p+=xO)
		for(q=xO;q<=yO;q+=xO)
			if(flag(p,q))
				n++;
	return n;
}
int main()
{
	scanf("%ld %ld",&xO,&yO);
	if(yO%xO!=0)
		printf("0");
	else
		printf("%ld",Cal());
	return 0;
}
