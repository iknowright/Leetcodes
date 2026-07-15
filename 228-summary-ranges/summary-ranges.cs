public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res=new();
        if(nums.Length==0) return res;

        
        int prev=nums[0], distance=1;
        for(int i=1; i<nums.Length; i++) {
            if(prev+distance==nums[i]) {
                distance++;
            }
            else {
                if(distance==1) {
                    res.Add(prev.ToString());
                    prev=nums[i];
                }
                else {
                    res.Add($"{prev}->{prev+distance-1}");
                    prev=nums[i];
                    distance=1;
                }
            }
        }
        if(distance>1) res.Add($"{prev}->{prev+distance-1}");
        else res.Add(prev.ToString());
        return res;
    }
}