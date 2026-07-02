public class Solution {
    HashSet<int> history=new();
    public bool IsHappy(int n) {
        int sum=0;
        while(n!=0) {
            sum+=(n%10)*(n%10);
            n/=10;
        }
        if(!history.Add(sum)) return false;
        else if(sum==1) return true;
        else return IsHappy(sum);
    }
}