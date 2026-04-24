public class Solution {
    public int MaxProfit(int[] prices) {
        var i = 0;
        var j = 0;
        var maxProfit = 0;

        while (j < prices.Length) {
            // j has higher price, so we potentially can make profit.
            // so we compare it to the max profit and if it is indeed
            // greater, then it is the new maximum profit.
            if (prices[j] > prices[i]) {
                var profit = prices[j] - prices[i];
                maxProfit = profit > maxProfit ? profit : maxProfit;
            }

            // j has lower price, we may find a better
            // profit next iter if we set this as buy point.
            else {
                i = j;
            }

            j++;
        }

        return maxProfit;
    }
}
