public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> res=new();
        for(int i=left; i<=right; i++) {
            if(SelfDividing(i)) res.Add(i);
        }
        return res;
    }
    public bool SelfDividing(int num) {
        int n, temp=num;
        while(temp!=0) {
            n=temp%10;
            if(n is 0) return false;
            else if(num%n !=0) return false;
            temp/=10;
        }
        return true;
    }
}