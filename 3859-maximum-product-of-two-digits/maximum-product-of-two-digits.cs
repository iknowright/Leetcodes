public class Solution {
    public int MaxProduct(int n) {
        int first=-1, second=-1, num;
        while(n!=0) {
            num=n%10;
            if(first<num) {
                second=first;
                first=num;
            }
            else if(second<num) second=num;
            n/=10;
        }
        return first*second;
    }
}