public class Solution {
    public long GcdSum(int[] nums) {
        int max=nums[0];
        int[] res = new int[nums.Length];
        for(int i=0; i<nums.Length; i++) {
            max=Math.Max(max, nums[i]);
            res[i] = Gcd(max, nums[i]);
        }
        Array.Sort(res);
        int left=0, right=nums.Length-1;
        long sum=0;
        while(left<right) {
            sum +=Gcd(res[left++], res[right--]);
        }
        return sum;
    }
    private int Gcd(int a, int b) => 
        b == 0 ? a : Gcd(b, a % b);
}