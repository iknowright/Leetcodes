public class Solution {
    public bool IsFascinating(int n) {
        string s = n.ToString()+ (n*2).ToString() + (n*3).ToString();
        bool[] nums = new bool[9];
        int digit;
        foreach(char c in s) {
            digit=c-'1';
            if(digit==-1 || nums[digit]) return false;
            else nums[digit]=true;
        }
        return true;
    }
}