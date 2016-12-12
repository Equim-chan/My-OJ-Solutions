// 35. Search Insert Position
// https://leetcode.com/problems/search-insert-position/
// by Equim on 16-12-07

int searchInsert(int* nums, int numsSize, int target) {
    int i;
    for(i=0;i<=numsSize-1;i++)
    {
        if(nums[i]>=target)
            return i;
    }
    return i;
}
