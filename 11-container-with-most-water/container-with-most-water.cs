public class Solution {
    public int MaxArea(int[] height) {
        int left=0, right=height.Length-1, area=0, width, heigth;
        while(left<right) {
            width=right-left;
            heigth=Math.Min(height[left], height[right]);
            area = Math.Max(area, width*heigth);


            // asked AI for condition
            if(height[left] < height[right]) left++;
            else right--;
        }
            return area;
    }
}