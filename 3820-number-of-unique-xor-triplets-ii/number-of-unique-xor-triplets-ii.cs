public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        HashSet<int> current=new() {0};

        for(int i=0; i<3; i++) {
            HashSet<int> next=new();
            foreach(int x in current) {
                foreach(int num in nums) next.Add(x^num);
            }
            current=next;
        }
        return current.Count;
    }
}