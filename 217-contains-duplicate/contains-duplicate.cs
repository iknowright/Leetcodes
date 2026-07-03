public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> distinct=new();
        foreach(int num in nums) {
            if(!distinct.Add(num)) return true;
        }
        return false;
    }
}