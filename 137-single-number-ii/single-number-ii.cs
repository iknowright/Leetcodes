public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> res=new();
        foreach(int num in nums) res[num]=res.GetValueOrDefault(num)+1;
        foreach(var kvp in res) {
            if(kvp.Value==1) return kvp.Key;
        }
        return -1;
    }
}