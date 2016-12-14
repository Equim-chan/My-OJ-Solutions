// 59. Spiral Matrix II
// https://leetcode.com/problems/spiral-matrix-ii/
// by Equim on 16-12-14

/**
 * @param {number} n
 * @return {number[][]}
 */
var generateMatrix = function(n)
{
    if (n === 1) return [[1]];
    if (n === 0) return [];
    
    var right = n;
    var left = -1;
    var up = -1;
    var down = n;
    
    var rtn = [[]];
    
    for (var t = 1;t < n;t++)
    {
        rtn.push(new Array(n));
    }
    
    var i = 0;
    var j = 0;
    var toPush = 1;
    var method = 1;
    
    while (toPush <= n * n)
    {
        switch (method)
        {
            case 1: rtn[i][j++] = toPush++;
                    if (j >= right)
                    {
                        j--;
                        i++;
                        up++;
                        method++;
                    }
                    break;
                    
            case 2: rtn[i++][j] = toPush++;
                    if (i >= down)
                    {
                        i--;
                        j--;
                        right--;
                        method++;
                    }
                    break;
                    
            case 3: rtn[i][j--] = toPush++;
                    if (j <= left)
                    {
                        j++;
                        i--;
                        down--;
                        method++;
                    }
                    break;
                    
            case 4: rtn[i--][j] = toPush++;
                    if (i <= up)
                    {
                        i++;
                        j++;
                        left++;
                        method = 1;
                    }
                    break;
        }
    }
    
    return rtn;
};
