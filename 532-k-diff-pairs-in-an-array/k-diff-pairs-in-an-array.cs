public class Solution {
    public int FindPairs(int[] nums, int k) {
        HashSet<int> res=new(), find=new();
        foreach(int num in nums) {
            if(find.Contains(num-k)) res.Add(num-k);
            if(find.Contains(num+k)) res.Add(num);
            find.Add(num);
        }
        return res.Count;
    }
}