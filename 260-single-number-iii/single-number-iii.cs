public class Solution {
    public int[] SingleNumber(int[] nums) {
        HashSet<int> set=new();
        
        foreach(int num in nums) {
            if(!set.Add(num)) set.Remove(num);
        }
        return set.ToArray();
    }
}