public class Solution {
    public bool CheckZeroOnes(string s) {
        int curr0=0, curr1=0, max0=0, max1=0;

        foreach(char c in s) {
            if(c is '1') {
                curr0=0; curr1++;
                max1 = Math.Max(max1, curr1);
            }
            else {
                curr1=0; curr0++;
                max0 = Math.Max(max0, curr0);
            }
        }
        return max1>max0;
    }
}