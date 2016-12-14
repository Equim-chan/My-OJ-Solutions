// Snail
// https://www.codewars.com/kata/snail/
// by Equim on 16-12-14

snail = function(array) {
    if (array[0].length == 0) return [];
    
    var right = array[0].length;
    var left = -1;
    var up = -1;
    var down = array.length;
    
    var method = 1;
    
    var i = 0;
    var j = 0;
    var rtn = [];
    
    while (rtn.length < array[0].length * array.length)
    {
        var toPush;
        switch (method)
        {
            case 1: toPush = array[i][j++];
                    if (j >= right)
                    {
                        j--;
                        i++;
                        up++;
                        method++;
                    }
                    break;
                    
            case 2: toPush = array[i++][j];
                    if (i >= down)
                    {
                        i--;
                        j--;
                        right--;
                        method++;
                    }
                    break;
                    
            case 3: toPush = array[i][j--];
                    if (j <= left)
                    {
                        j++;
                        i--;
                        down--;
                        method++;
                    }
                    break;
                    
            case 4: toPush = array[i--][j];
                    if (i <= up)
                    {
                        i++;
                        j++;
                        left++;
                        method = 1;
                    }
                    break;
        }
        rtn.push(toPush);
    }
    
    return rtn;
}
