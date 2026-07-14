public class Solution {
    public int SmallestIndex(int[] nums) {
        for(int i=0; i<nums.Length; i++) {
            if(Match(nums[i], i)) return i;
        }
        return -1;
    }
    public bool Match(int num, int sum) {
        int temp=0;
        while(num!=0) {
            temp+=num%10; num/=10;
        }
        return temp==sum;
    }
}