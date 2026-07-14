public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices);
        if(prices[0]+prices[1]>money) return money;
        return money-prices[0]-prices[1];
    }
}