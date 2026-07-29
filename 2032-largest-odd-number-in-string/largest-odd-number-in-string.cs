public class Solution {
    public string LargestOddNumber(string num) {
        int i=num.Length-1;
        while(i>=0 && (num[i]-'0')%2==0) i--;
        return num.Substring(0, i+1);
    }
}