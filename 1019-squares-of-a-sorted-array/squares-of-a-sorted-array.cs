public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] squares = new int[nums.Length];
        int left=0, right=nums.Length-1, i=nums.Length-1;
        while(left<=right) {
            if(Math.Abs(nums[left])>= nums[right]) {
                squares[i--]= nums[left]*nums[left];
                left++;
            }
            else {
                squares[i--] = nums[right]*nums[right];
                right--;
            }
        }
        return squares;
    }
}