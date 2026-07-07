public class Solution {
    public int[] PlusOne(int[] digits) {
        int i=digits.Length-1;
        bool carry=true;
        while(carry) {
            if(i<0) {
                int[] arr = new int[digits.Length+1];
                arr[0]=1;
                return arr;
            }
            if(digits[i]==9) digits[i--]=0;
            else {
                digits[i]++;
                carry=false;
            }
        }
        return digits;
    }
}