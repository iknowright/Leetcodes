public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        long sum=0;
        List<bool> res=new();
        foreach(int num in nums) {
            sum = (sum*2 + num)%5;
            res.Add(sum==0);
        }
        return res;
    }
}