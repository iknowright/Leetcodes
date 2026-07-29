public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> res=new();
        foreach(int num in nums) {
            if(!res.Add(num)) return num;
        }
        return -1;
    }
}