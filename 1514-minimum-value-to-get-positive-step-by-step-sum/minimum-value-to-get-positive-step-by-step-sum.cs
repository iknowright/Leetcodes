public class Solution {
    public int MinStartValue(int[] nums) {
        int min=0, sum=0;
        foreach(int num in nums) {
            sum+= num;
            min = Math.Min(min, sum);
        }
        return 1-min;
    }
}