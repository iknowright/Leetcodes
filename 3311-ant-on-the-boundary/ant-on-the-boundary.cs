public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int boundary=0, count=0;
        foreach(int num in nums) {
            boundary+=num;
            if(boundary is 0) count++;
        }
        return count;
    }
}