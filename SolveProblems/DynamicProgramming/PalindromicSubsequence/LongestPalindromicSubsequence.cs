using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.PalindromicSubsequence
{
    /*Problem Statment
    Given a sequence, find the length of its Longest Palindromic Subsequence (LPS). In a palindromic subsequence, elements read the same backward and forward.
    A subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.

     * Example 1:
        Input: "abdbca"
        Output: 5
        Explanation: LPS is "abdba".
        
     * Example 2:
        Input: = "cddpd"
        Output: 3
        Explanation: LPS is "ddd".
       
     * Example 3:
        Input: = "pqr"
        Output: 1
        Explanation: LPS could be "p", "q" or "r".
    
     * Basic Solution
         A basic brute-force solution could be to try all the subsequences of the given sequence. 
         * We can start processing from the beginning and the end of the sequence. So at any step, we have two options:
           If the element at the beginning and the end are the same, we increment our count by two and make a recursive call for the remaining sequence.
           We will skip the element either from the beginning or the end to make two recursive calls for the remaining subsequence.
           If option one applies then it will give us the length of LPS; 
           otherwise, the length of LPS will be the maximum number returned by the two recurse calls from the second option.
     */

    class LongestPalindromicSubsequence
    {
        public int SolveLongestPalindromicSubsequence(string str)
        {
            return SolveLongestPalindromicSubsequence(str, 0, str.Length - 1);
        }

        private int SolveLongestPalindromicSubsequence(string str, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return 0;
            if (startIndex == endIndex)
                return 1;

            if(str[startIndex] == str[endIndex])
            {
                return 2 + SolveLongestPalindromicSubsequence(str, startIndex + 1, endIndex - 1);
            }

            int p1 = SolveLongestPalindromicSubsequence(str, startIndex + 1, endIndex);
            int p2 = SolveLongestPalindromicSubsequence(str, startIndex, endIndex - 1);

            return Math.Max(p1, p2);
        }

        public int SolveLongestPalindromicSubsequenceDP(string str)
        {
            int[][] dpCache = new int[str.Length][];
            for (int i = 0; i < str.Length; i++)
            {
                dpCache[i] = new int[str.Length];
            }
            return SolveLongestPalindromicSubsequenceDP(str, 0, str.Length - 1, dpCache);
        }

        private int SolveLongestPalindromicSubsequenceDP(string str, int startIndex, int endIndex, int[][] dpCache)
        {
            if (startIndex > endIndex)
                return 0;
            if (startIndex == endIndex)
                return 1;

            if (dpCache[startIndex][endIndex] <= 0)
            {
                if (str[startIndex] == str[endIndex])
                {
                    dpCache[startIndex][endIndex] = 2 + SolveLongestPalindromicSubsequenceDP(str, startIndex + 1, endIndex - 1, dpCache);
                }
                else
                {
                    int p1 = SolveLongestPalindromicSubsequenceDP(str, startIndex + 1, endIndex, dpCache);
                    int p2 = SolveLongestPalindromicSubsequenceDP(str, startIndex, endIndex - 1, dpCache);
                    dpCache[startIndex][endIndex] = Math.Max(p1, p2);
                }
            }
            return dpCache[startIndex][endIndex];
        }

        public int SolveLongestPalindromicSubsequenceIterative(string str)
        {
            if (str.Length == 0)
                return 0;
            if (str.Length == 1)
                return 1;
            int n = str.Length;
            int[][] dpCache = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                dpCache[i][i] = str[i];
            }

            for (int endIndex = 0; endIndex < n; endIndex++)
            {
                for (int startIndex = endIndex - 1; startIndex <= 0; startIndex--)
                {
                    if(str[startIndex]==str[endIndex])
                    {
                        dpCache[startIndex][endIndex] = 2 + dpCache[startIndex + 1][endIndex - 1];
                    }
                    else
                    {
                        dpCache[startIndex][endIndex] = Math.Max(dpCache[startIndex + 1][endIndex], dpCache[startIndex][endIndex - 1]);
                    }
                }
            }
            return dpCache[n - 1][0];
        }
    }
}
