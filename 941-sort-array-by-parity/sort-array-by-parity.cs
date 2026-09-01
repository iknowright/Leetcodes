public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int left=0, right=nums.Length-1, temp;

        while(left<right) {
            while(left<right && nums[left]%2==0) left++;
            while(left<right && nums[right]%2==1) right--;

            if(left<right) {
                temp = nums[left];
                nums[left++] = nums[right];
                nums[right--] = temp;
            }
        }
        return nums;
    }
}