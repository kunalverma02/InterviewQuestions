using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming
{
    /* 
     * Given the weights and profits of ‘N’ items, we are asked to put these items in a knapsack which has a capacity ‘C’. 
     * The goal is to get the maximum profit from the items in the knapsack. 
     * Each item can only be selected once, as we don’t have multiple quantities of any item.

        Let’s take the example of Merry, who wants to carry some fruits in the knapsack to get maximum profit. Here are the weights and profits of the fruits:

        Items: { Apple, Orange, Banana, Melon }
        Weights: { 2, 3, 1, 4 }
        Profits: { 4, 5, 3, 7 }
        Knapsack capacity: 5

        Let’s try to put different combinations of fruits in the knapsack, such that their total weight is not more than 5:

        Apple + Orange (total weight 5) => 9 profit
        Apple + Banana (total weight 3) => 7 profit
        Orange + Banana (total weight 4) => 8 profit
        Banana + Melon (total weight 5) => 10 profit

        This shows that Banana + Melon is the best combination, as it gives us the maximum profit and the total weight does not exceed the capacity.

Problem Statement
     * Given two integer arrays to represent weights and profits of ‘N’ items, 
     * we need to find a subset of these items which will give us maximum profit such that their cumulative weight is not more than a given number ‘C’. 
     * Each item can only be selected once, which means either we put an item in the knapsack or we skip it.
     */
    public class Knapsack
    {
       
       public int SolveKnapsackRecursive(int [] profits, int[] weights, int capacity )
       {
           return this.KnapsackRecursive(profits, weights, capacity, 0);
       }
       private int KnapsackRecursive(int [] profits, int[] weights, int capacity, int currentIndex)
       {
           if (profits.Length == 0 || weights.Length == 0 || capacity <= 0 || currentIndex >= weights.Length)
               return 0;

           int profit1=0, profit2 = 0;

           if(weights[currentIndex] <= capacity)
           {
               profit1 = profits[currentIndex] + KnapsackRecursive(profits, weights, capacity - weights[currentIndex], currentIndex + 1);
           }

           profit2 = KnapsackRecursive(profits, weights, capacity, currentIndex + 1);

           return Math.Max(profit1, profit2);
       }


       public int SolveKnapsackRecursiveMemoization(int[] profits, int[] weights, int capacity)
       {
           int[,] dp = new int[profits.Length , capacity +1];

           return KnapsackRecursiveMemoization(dp, profits, weights, capacity, 0);
       }

       private int KnapsackRecursiveMemoization(int[,] dp, int [] profits, int[] weights, int capacity, int currentIndex)
       {
           if (profits.Length == 0 || weights.Length == 0 || capacity <= 0 || currentIndex >= weights.Length || currentIndex <0)
               return 0;
          
           if(dp[currentIndex, capacity] != 0)
           {
               return dp[currentIndex, capacity];
           }
           int profit1 = 0, profit2 = 0;

           if (weights[currentIndex] <= capacity)
           {
               profit1 = profits[currentIndex] + KnapsackRecursive(profits, weights, capacity - weights[currentIndex], currentIndex + 1);
           }

           profit2 = KnapsackRecursive(profits, weights, capacity, currentIndex + 1);

           dp[currentIndex, capacity] = Math.Max(profit1, profit2);
           return dp[currentIndex, capacity];
       }

       public int KnapsackIterative(int[] profits, int[] weights, int capacity)
       {
           if (profits.Length == 0 || weights.Length == 0 || capacity <= 0)
               return 0;

           int n = profits.Length;
           int[][] dp = new int[n][];

           //initialize all child array
           for (int i = 0; i < n; i++)
           {        
               dp[i] = new int[capacity +1];
           }

           //for capacity 0 profit will be zero.
           for (int i = 0; i < n; i++)
           {
               dp[i][0] = 0;
           }

           for (int i = 0; i <= capacity; i++)
           {
               if (weights[0] <= capacity)
                   dp[0][i] = profits[0];
           }

           for (int i = 1; i < n; i++)
           {
               for (int c = 1; c <= capacity; c++)
               {
                   int profit1 = 0;
                   int profit2 = 0;

                   if (weights[i] <= c)
                       profit1 = profits[i] + dp[i - 1][c - weights[i]];
                   profit2 = dp[i - 1][c];

                   dp[i][c] = Math.Max(profit1, profit2);
               }
           }

           return dp[n - 1][capacity];
       }

       public int KnapsackIterativeLessSpace(int[] profits, int[] weights, int capacity)
       {
           if (profits.Length == 0 || weights.Length == 0 || capacity <= 0)
               return 0;

           int n = profits.Length;
           int[] dp = new int[capacity +1];


           for (int i = 0; i <= capacity; i++)
           {
               if (weights[0] <= capacity)
                   dp[i] = profits[0];
           }

           for (int i = 1; i < n; i++)
           {
               for (int c = capacity; c >=0; c++)
               {
                   int profit1 = 0;
                   int profit2 = 0;

                   if (weights[i] <= c)
                       profit1 = profits[i] + dp[c - weights[i]];

                   profit2 = dp[c];

                   dp[c] = Math.Max(profit1, profit2);
               }
           }

           return dp[capacity];
       }
    }
}
