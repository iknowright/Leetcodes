public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int curr=0;
        foreach(int num in nums) {
            if(curr<2 || num>nums[curr-2]) nums[curr++] = num;
        }
        return curr;
    }
}