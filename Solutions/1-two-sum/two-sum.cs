public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pairs = [];
        for(int i=0; i<nums.Length; i++) {
            if(pairs.TryGetValue(target-nums[i], out int val)) {
                return [i, val];
            }
            else pairs[nums[i]]=i;
        }
        return [-1, -1];
    }
}