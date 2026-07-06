public class Solution {
    public int Maximum69Number (int num) {
        char[] nums = num.ToString().ToCharArray();
        for(int i=0; i<nums.Length; i++) {
            if(nums[i]=='6') {
                nums[i]='9';
                break;
            }
        }
        return int.Parse(new string(nums));
    }
}
