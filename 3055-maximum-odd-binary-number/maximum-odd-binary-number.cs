public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int ones=0, zeroes=0;
        foreach(char c in s) {
            if(c is '1') ones++;
            else zeroes++;
        }
        return new string('1', ones-1) + new string('0', zeroes) + "1";
    }
}