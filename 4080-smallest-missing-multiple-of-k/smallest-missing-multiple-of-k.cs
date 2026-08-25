public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        HashSet<int> set = new HashSet<int>(nums);
        int num=k;
        while(set.Contains(num)) num+=k;

        return num;
    }
}