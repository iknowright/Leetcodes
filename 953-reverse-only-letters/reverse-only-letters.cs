public class Solution {
    public string ReverseOnlyLetters(string s) {
        int left=0, right=s.Length-1;
        char temp;
        char[] str = s.ToCharArray();
        while(left<right) {
            while(left<right && !char.IsLetter(str[left])) left++;
            while(left<right && !char.IsLetter(str[right])) right--;
            temp=str[left];
            str[left++]=str[right];
            str[right--]=temp;
        }
        return new string(str);
    }
}