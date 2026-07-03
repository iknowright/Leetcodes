public class Solution {
    public int AddDigits(int num) {
        if(num<10) return num;
        int temp=0;
        while(num!=0) {
            temp+=num%10; num/=10;
        }
        return AddDigits(temp);
    }
}