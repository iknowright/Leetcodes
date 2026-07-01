public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pairs = new();
        for(int i=0; i<nums.Length; i++) {
            if(pairs.TryGetValue(target-nums[i], out int val)) {
                return new int[] {i, val};
            }
            else pairs[nums[i]]=i;
        }
        return new int[] {-1, -1};
    }
}