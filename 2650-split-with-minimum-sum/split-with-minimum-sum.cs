public class Solution {
    public int SplitNum(int num) {
        char[] nums = num.ToString().ToCharArray();
        Array.Sort(nums);
        string res1="", res2="";
        for(int i=0; i<nums.Length; i++) {
            if(i%2==0)res1+=nums[i];
            else res2+=nums[i];
        }
        return int.Parse(res1) + int.Parse(res2);
    }
}