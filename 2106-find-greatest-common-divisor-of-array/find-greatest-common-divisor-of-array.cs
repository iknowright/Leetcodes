public class Solution {
    public int FindGCD(int[] nums) {
        int min=nums[0], max=nums[0];
        foreach(int num in nums) {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        return GCD(min, max);
    }
    public int GCD(int a, int b) {
        while(b!=0) {
            int temp = b;
            b = a%b;
            a = temp;
        }
        return a;
    }
}