public class Solution {
    public bool IsPossibleToSplit(int[] nums) {
        int[] counts = new int [101];
        foreach(int num in nums) {
            if(counts[num]==2) return false;
            counts[num]++;
        }
        return true;
    }
}