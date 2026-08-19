public class Solution {
    public long FindTheArrayConcVal(int[] nums) {
        int left=0, right=nums.Length-1;
        long res=0;
        while(left<right) {
            res += long.Parse($"{nums[left++]}{nums[right--]}");
        }
        if(left==right) res+= nums[left];
        return res;
    }
}