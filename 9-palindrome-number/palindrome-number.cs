public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        string num=x.ToString();
        int left=0, right=num.Length-1;
        while(left<right) {
            if(num[left++] != num[right--]) return false;
        }
        return true;
    }
}