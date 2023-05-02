using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxProfit
    {
        // Naive Solution
        // Nested loop running for each n on every m to find max possible profit
        // where (SellPrice - BuyPrice) = Profit
        // TotalTime - 14min
        // Time Complexity: O(n^2)
        // Space Complexity: O(1)

        //public int MaxProfitFunc(int[] prices)
        //{
        //    int maxProfit = 0;
        //    for (int i = 0; i < prices.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            int currBuy = prices[i];
        //            int currSell = prices[j];
        //            int tempResult = currSell - currBuy;
        //            if (tempResult > maxProfit)
        //                maxProfit = tempResult;
        //            Console.WriteLine($"i-{i}, prices[i]-{prices[i]}, j-{j}, prices[j]-{prices[j]}.     MaxProfit={maxProfit}");
        //        }
        //    }
        //    return maxProfit;
        //}


        public int MaxProfitFunc(int[] prices)
        {
            // Optimal Solution
            // We iterate through the array once, keep 2 key points:
            // lowest 'buy' point -> if we reached a lower buy option, we update it to prices[i]
            // maxProfit if we sell at [i] day -> we check what is bigger, the current profit  
            // OR if we sell today against the lowestPoint we been to.
            // then we return the maximum profit we accumulated so far.
            int lowestPoint = 10000;
            int maxDifference = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < lowestPoint)
                    lowestPoint = prices[i];
                else
                    maxDifference = Math.Max(maxDifference, prices[i] - lowestPoint);
            }
            return maxDifference;
        }

        









        // Algorithm Solution
    }
}
