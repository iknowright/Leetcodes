public class Solution {
    public int MinMoves(int[] nums) {
        int min=nums[0];
        long res=0;

        foreach(int num in nums) {
            if(num<min) min=num;
            res +=num;
        }
        return (int)(res - (long)min*nums.Length);
    }
}