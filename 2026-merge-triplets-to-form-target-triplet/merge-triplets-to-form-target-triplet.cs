public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool x=false, y=false, z=false;

        foreach(var triplet in triplets) {
            if(triplet[0]>target[0] || triplet[1]>target[1] || triplet[2]>target[2]) continue;

            if (triplet[0]==target[0]) x = true;
            if (triplet[1]==target[1]) y = true;
            if (triplet[2]==target[2]) z = true;

            if(x && y && z) return true;
        }
        
        return x && y && z;
    }
}