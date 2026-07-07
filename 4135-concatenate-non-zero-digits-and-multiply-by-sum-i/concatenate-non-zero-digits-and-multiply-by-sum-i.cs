public class Solution {
    public long SumAndMultiply(int n) {
        string num = n.ToString();
        long x=0;
        for(int i=0; i<num.Length; i++) {
            if(num[i]!='0') x=x*10 + (num[i]-'0');
        }
        long sum=0, temp=x;
        while(temp!=0) {
            sum+=temp%10;
            temp/=10;
        }
        return (long)x*sum;
    }
}