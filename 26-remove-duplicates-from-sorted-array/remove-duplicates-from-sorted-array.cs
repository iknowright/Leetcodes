public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int distinct=0;
        foreach(int num in nums) {
            if(nums[distinct]!=num) {
                nums[++distinct]=num;
            }
        }
        return distinct+1;
    }
}