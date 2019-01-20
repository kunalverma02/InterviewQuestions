using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.UnBoundedKnapsack
{
    /*
     
     Introduction
     *  Given the weights and profits of ‘N’ items, we are asked to put these items in a knapsack which has a capacity ‘C’. 
     *  The goal is to get the maximum profit from the items in the knapsack. T
     *  he only difference between the 0/1 Knapsack problem and this problem is that we are allowed to use an unlimited quantity of an item.

        Let’s take the example of Merry, who wants to carry some fruits in the knapsack to get maximum profit. Here are the weights and profits of the fruits:
        Items: { Apple, Orange, Melon }
        Weights: { 1, 2, 3 }
        Profits: { 15, 20, 50 }
        Knapsack capacity: 5

        Let’s try to put different combinations of fruits in the knapsack, such that their total weight is not more than 5.

        5 Apples (total weight 5) => 75 profit
        1 Apple + 2 Oranges (total weight 5) => 55 profit
        2 Apples + 1 Melon (total weight 5) => 80 profit
        1 Orange + 1 Melon (total weight 5) => 70 profit

        This shows that 2 apples + 1 melon is the best combination, as it gives us the maximum profit and the total weight does not exceed the capacity.

        Problem Statment
        Given two integer arrays to represent weights and profits of ‘N’ items, 
     *  we need to find a subset of these items which will give us maximum profit such that their cumulative weight is not more than a given number ‘C’. 
     *  We can assume an infinite supply of item quantities; therefore, each item can be selected multiple times.
     
     */
    class UnboundedKnapsack
    {
        public int GetMaximumProfit(int[] profits, int[] weights, int capacity)
        {
            if (profits.Length == 0 || profits.Length != weights.Length || capacity <= 0)
                return 0;
            int n = profits.Length;
            int[][] dpCache = new int[n][];
            //initialize the child arrays
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[capacity + 1];
            }

            //Set profit 0 when capacity is zero
            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int c = 1; c <= capacity; c++)
                {
                    int profit1 = 0, profit2 = 0;
                    
                    if(weights[i] <= c)
                    {
                        profit1 = profits[i] + dpCache[i][c - weights[i]];
                    }
                    if(i >0)
                    {
                        profit2 = dpCache[i - 1][c];
                    }

                    dpCache[i][c] = Math.Max(profit1, profit2);
                }
            }
            int profit = dpCache[n-1][capacity];
            int cap = capacity;
            //print the selected items
            for (int i = n - 1; i >0; i--)
            {
                if (dpCache[i-1][cap] != profit)
                {
                    Console.WriteLine(weights[i]);
                    cap = cap - weights[i];
                    profit = profit - profits[i];
                }
            }
            if(profit !=0  && dpCache[0][cap] == profit )
                Console.WriteLine(weights[0]);
            return dpCache[n - 1][capacity];
        }
    }
}
