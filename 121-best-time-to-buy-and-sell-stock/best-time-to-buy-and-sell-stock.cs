public class Solution {
    public int MaxProfit(int[] prices) {
        int buy=prices[0], profit=0;
        foreach(int price in prices) {
            if(price<buy) buy=price;
            else if(price-buy>profit) profit=price-buy;
        }
        return profit;
    }
}