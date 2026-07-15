public class Solution {
    public int FindClosestNumber(int[] nums) {
        int min=int.MaxValue;

        foreach(int num in nums) {
            if(Math.Abs(num)<Math.Abs(min)) {
                min=num;
            }
            else if(Math.Abs(num)==Math.Abs(min)) min = Math.Max(min, num);
        }
        return min;
    }
}