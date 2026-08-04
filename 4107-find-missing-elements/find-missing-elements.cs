public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        HashSet<int> set=new();
        int min=nums[0], max=nums[0];
        foreach(int num in nums) {
            min = Math.Min(num, min);
            max = Math.Max(num, max);
            set.Add(num);
        }
        List<int> res=new();
        for(int i=min+1; i<max; i++) {
            if(set.Add(i)) res.Add(i);
        }
        return res;
    }
}