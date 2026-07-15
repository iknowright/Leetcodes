public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> res=new();
        res.Add(defaultList());

        for(int i=1; i<numRows; i++) {
            var prev = res[i-1];
            var curr = defaultList();
            for(int j=1; j<i; j++) {
                curr.Add(prev[j-1] + prev[j]);
            }
            curr.Add(1);
            res.Add(curr);
        }
        return res;
    }

    public List<int> defaultList() {
        return new List<int> {1};
    }
}