public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int, int> res=new();
        foreach(int num in nums) {
            res[num]=res.GetValueOrDefault(num)+1;
        }
        
        int sum=0;
        foreach(var kvp in res) {
            if(kvp.Value==1) sum+=kvp.Key;
        }
        return sum;
    }
}