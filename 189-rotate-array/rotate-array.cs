public class Solution {
    public int[] _nums;
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        _nums = nums;

        Reverse(0, nums.Length-1);
        Reverse(0, k-1);
        Reverse(k, nums.Length-1);
    }

    public void Reverse(int start, int end) {
        int temp;
        while(start<end) {
            temp=_nums[start];
            _nums[start++]=_nums[end];
            _nums[end--]=temp;
        }
    }
}