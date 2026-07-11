public class Solution {
    string res="";
    public string ToHex(int num) {
        if(num==0) return "0";
        long n=num;
        if(num<0) n+=(long)Math.Pow(2, 32);

        while(n!=0) {
            res=Hex(n%16)+res;
            n/=16;
        }
        return res;
    }

    public char Hex(long num) {
        if(num>9) return (char)('a'+num-10);
        else return (char)('0'+num);
    }
}