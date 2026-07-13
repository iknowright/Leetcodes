public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length], res = new int[nums.Length];
        int product=1;

        for(int i=0; i<nums.Length; i++) {
            prefix[i] = product;
            product*=nums[i];
        }
        product=1;
        
        for(int i=nums.Length-1; i>=0; i--) {
            res[i] = prefix[i]*product;
            product*=nums[i];
        }
        return res;
    }
}