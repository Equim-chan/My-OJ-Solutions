// P1975 扫雷游戏
// https://vijos.org/p/1975
// by Equim on 15-12-15

#include<stdio.h>
char range[100][100]={{'\0'}};
int n,m;
char Detect(int y,int x)
{
	int i='0';
	if((y-1>=0)&&(x-1>=0)&&(range[y-1][x-1]=='*'))
		i++;
	if((y-1>=0)&&(range[y-1][x]=='*'))
		i++;
	if((y-1>=0)&&(x+1<=m)&&(range[y-1][x+1]=='*'))
		i++;
	if((x-1>=0)&&(range[y][x-1]=='*'))
		i++;
	if((x+1<=m)&&(range[y][x+1]=='*'))
		i++;
	if((y+1<=n)&&(x-1>=0)&&(range[y+1][x-1]=='*'))
		i++;
	if((y+1<=n)&&(range[y+1][x]=='*'))
		i++;
	if((y+1<=n)&&(x+1<=m)&&(range[y+1][x+1]=='*'))
		i++;
	return i;
}
int main()
{
	int i,j;
 	scanf("%d %d\n",&n,&m);
 	n--;
 	m--;
 	for(j=0;j<=n;j++)
		scanf("%s",range[j]);
 	for(j=0;j<=n;j++)
 		for(i=0;i<=m;i++)
 			if(range[j][i]=='?')
	 			range[j][i]=Detect(j,i);
 	for(j=0;j<=n;j++)
 	{
 		for(i=0;i<=m;i++)
 			printf("%c",range[j][i]);
		printf("\n");
	}
 	return 0;
}
