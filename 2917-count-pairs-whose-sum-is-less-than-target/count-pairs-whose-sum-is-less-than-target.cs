public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int res=0, left=0, right=nums.Count-1;
        List<int> sorted = new List<int>(nums);
        sorted.Sort();
        while(left<right) {
            if(sorted[left]+sorted[right]<target) {
                res += right-left;
                left++;
            }
            else right--;
        }

        return res;
    }
}