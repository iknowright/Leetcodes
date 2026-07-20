public class Solution {
    public int AccountBalanceAfterPurchase(int purchaseAmount) {
        int round = (purchaseAmount%10<5)? 0:10;
        int balance = (purchaseAmount/10)*10 + round;
        return 100 - balance;
    }
}