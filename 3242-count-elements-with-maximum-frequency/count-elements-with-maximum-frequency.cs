public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> res=new();
        int max=0;
        foreach(int num in nums) {
            res[num]=res.GetValueOrDefault(num)+1;
            max = Math.Max(max, res[num]);
        }

        int count=0;
        foreach(var kvp in res) {
            if(kvp.Value==max) count+=max;
        }
        return count;
    }
}