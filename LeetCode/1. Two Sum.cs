// 1.Two Sum
// https://leetcode.com/problems/two-sum/
// by Equim on 16-12-07

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<=nums.Length-1;i++)
            for(int j=i+1;j<=nums.Length-1;j++)
                if(nums[i] + nums[j] == target)
                {
                    int[] result = {i, j};
                    return result;
                }
        return null;
    }
}
