using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /*Say you have an array for which the ith element is the price of a given stock on day i.

        If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

        Note that you cannot sell a stock before you buy one.

        Example 1:
        Input: [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
                     Not 7-1 = 6, as selling price needs to be larger than buying price.
     
        Example 2:
        Input: [7,6,4,3,1]
        Output: 0
        Explanation: In this case, no transaction is done, i.e. max profit = 0.
     */
    class SellAStock1
    {
        public int MaxProfit(int[] priceArray)
        {
            int profit = 0;
            int buyPrice = 0;
            int sellPrice = 0;
            int maxProfit = 0;
            for (int i = 0; i < priceArray.Length; i++)
            {
                for (int j = i + 1; j < priceArray.Length; j++)
                {
                    if (priceArray[i] > priceArray[j])
                    {
                        break;
                    }
                    else
                    {
                        buyPrice = priceArray[i];
                        sellPrice = priceArray[j];
                        profit = sellPrice - buyPrice;
                        if (profit >= maxProfit)
                            maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        public int MaxProfit2(int[] prices)
        {
            int buyPrice = int.MaxValue;;
            int maxProfit =0;

            for (int i = 0; i < prices.Length; i++)
            {
                if(buyPrice < prices[i])
                {
                    buyPrice = prices[i];
                }
                else if(prices[i]-buyPrice > maxProfit)
                {
                    maxProfit = prices[i] - buyPrice;
                }
            }


            return maxProfit;
        }
    }
}
