public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> res=new();
        for(int i=0; i<nums.Length; i++) {
            if(res.TryGetValue(nums[i], out int first)) {
                if(i-first<= k) return true;
            }
            res[nums[i]] = i;
        }
        return false;
    }
}