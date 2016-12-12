// 35. Search Insert Position
// https://leetcode.com/problems/search-insert-position/
// by Equim on 16-12-07

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int index = -1;
        foreach(var item in nums)
        {
            index++;
            if(item>=target)
                return index;
        }
        return index+1;
    }
}
