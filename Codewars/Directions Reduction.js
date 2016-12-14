// Directions Reduction
// http://www.codewars.com/kata/directions-reduction
// by Equim on 16-12-14

function dirReduc(arr)
{
    var opposite = { "NORTH":"SOUTH" , "SOUTH":"NORTH", "WEST":"EAST", "EAST":"WEST" };
    for (var i = 1;i < arr.length;i++)
    {
        while (opposite[arr[i]] === arr[i - 1] && arr.length > 0)
        {
            arr.splice(--i, 2);
        }
    }
    return arr;
}
