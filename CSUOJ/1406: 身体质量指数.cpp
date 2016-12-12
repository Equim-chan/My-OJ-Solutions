// 1406: 身体质量指数
// http://acm.csu.edu.cn/OnlineJudge/problem.php?id=1406
// by Equim on 16-12-13

#include <cstdio>

int main()
{
    int total;
    scanf("%d", &total);
    for (int i = 1;i <= total;i++)
    {
        float weight, height;
        scanf("%f%f", &weight, &height);
        float BMI = weight/height/height;
        if (BMI < 18.5)
            printf("Underweight\n");
        else if (BMI >= 23)
            printf("Overweight\n");
        else
            printf("Normal\n");
    }
    return 0;
}
