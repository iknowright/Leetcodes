public class Solution {
    public int CountKDifference(int[] nums, int k) {
        Dictionary<int, int> find=new();
        int res=0;

        foreach(int num in nums) {
            if(find.ContainsKey(num-k)) res+=find[num-k];
            if(find.ContainsKey(num+k)) res+=find[num+k];
            find[num] = find.GetValueOrDefault(num)+1;
        }
        return res;
    }
}