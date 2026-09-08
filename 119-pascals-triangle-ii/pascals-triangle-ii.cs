public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> res=new();
        long curr=1;

        for(int i=0; i<=rowIndex; i++) {
            res.Add((int)curr);
            curr = curr*(rowIndex-i)/(i+1);
        }
        return res;
    }
}