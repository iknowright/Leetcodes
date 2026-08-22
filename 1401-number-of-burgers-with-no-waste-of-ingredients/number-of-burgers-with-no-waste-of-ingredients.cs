public class Solution {
    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) {
        int t=tomatoSlices, c=cheeseSlices;
        if( t%2!=0 || t>c*4 || t<2*c) return new List<int>();
        return new List<int> {(t-2*c)/2, c-(t-2*c)/2};
    }
}