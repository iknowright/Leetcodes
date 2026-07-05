public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int[] res=new int[num_people];
        int turn=0, candy;
        while(candies!=0) {
            candy = (candies>turn+1) ? (turn+1) : candies;
            candies-=candy;
            res[turn%num_people] += candy;
            turn++;
        }
        return res;
    }
}