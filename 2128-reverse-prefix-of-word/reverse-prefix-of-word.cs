public class Solution {
    public string ReversePrefix(string word, char ch) {
        char[] s = word.ToCharArray();
        for(int i=0; i<s.Length; i++) {
            if(s[i]==ch) {
                int left=0, right=i;
                char temp;
                while(left<right) {
                    temp=s[left];
                    s[left++] = s[right];
                    s[right--] = temp;
                }
                break;
            }
        }
        return new string(s);
    }
}