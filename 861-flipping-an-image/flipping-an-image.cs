public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int left, right, temp;
        foreach(int[] img in image) {
            left=0; right=img.Length-1;
            while(left<=right) {
                temp = img[left];
                img[left++] = img[right]==0? 1:0;
                img[right--] = temp==0? 1:0;
            }
        }
        return image;
    }
}