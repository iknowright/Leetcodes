public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        if (nums.Length < 3) return -1;
        int a=nums[0], b=nums[1], c=nums[2];
        
        if((a>b && a<c) || (a<b && a>c)) return a;
        else if((b>c && b<a) || (b<c && b>a)) return b;
        else return c;
    }
}