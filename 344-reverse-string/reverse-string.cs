public class Solution {
    public void ReverseString(char[] s) {
        char temp;
        int left=0, right=s.Length-1;
        while(left<right) {
            temp=s[left];
            s[left++]=s[right];
            s[right--]=temp;
        }
    }
}