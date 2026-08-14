public class Solution {
    public long SmallestNumber(long num) {
        if(num==0) return 0;
        bool negative = num<0;
        var nums = Math.Abs(num).ToString().ToCharArray();
        Array.Sort(nums);

        if(negative) {
            Array.Reverse(nums);
            return -long.Parse(new string(nums));
        }

        for(int i=0; i<nums.Length; i++) {
            if(nums[i] != '0') {
                char temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
                break;
            }
        }
        return long.Parse(new string(nums));
    }
}