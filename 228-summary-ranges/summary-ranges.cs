public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res=new();
        if(nums.Length==0) return res;

        for(int i=0; i<nums.Length; i++) {
            int start=nums[i];
            while(i<nums.Length-1 && (nums[i]+1==nums[i+1])) i++;

            if(start==nums[i]) res.Add(start.ToString());
            else res.Add($"{start}->{nums[i]}");
        }
        return res;
    }
}