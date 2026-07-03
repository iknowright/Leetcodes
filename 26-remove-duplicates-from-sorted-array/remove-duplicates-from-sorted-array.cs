public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int distinct=0;//0
        // 0,0,1,1,1,2,2,3,3,4
        foreach(int num in nums) {
            if(nums[distinct] !=num) {
                nums[++distinct]=num;
            }
        }
        return distinct+1;
    }
}