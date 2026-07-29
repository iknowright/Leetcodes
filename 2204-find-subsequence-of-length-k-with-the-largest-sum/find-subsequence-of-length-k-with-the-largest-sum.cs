public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        return nums.Select((val, index) => (val, index)).OrderByDescending(x => x.val).Take(k).OrderBy(x => x.index).Select(x => x.val).ToArray();
    }
}