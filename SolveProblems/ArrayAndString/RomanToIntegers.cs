﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /* Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
        Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

        Example 1:
        Input: "III"
        Output: 3
       
        Example 2:
        Input: "IV"
        Output: 4
      
        Example 3:
        Input: "IX"
        Output: 9
     
        Example 4:
        Input: "LVIII"
        Output: 58
        Explanation: L = 50, V= 5, III = 3.
     
        Example 5:
        Input: "MCMXCIV"
        Output: 1994
        Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.*/
    class RomanToIntegers
    {
        public int ChangeRomanToIntegers(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && s[i] == 'I' && (s[i + 1] == 'X' || s[i + 1] == 'V'))
                {
                    sum = sum - ReturnNumForRomanChar(s[i]);
                }
                else if (i < s.Length - 1 && s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                {
                    sum = sum - ReturnNumForRomanChar(s[i]);
                }
                else if (i < s.Length - 1 && s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                {
                    sum = sum - ReturnNumForRomanChar(s[i]);
                }
                else
                {
                    sum = sum + ReturnNumForRomanChar(s[i]);
                }
            }

            return sum;
        }

        private int ReturnNumForRomanChar(char c)
        {
            int result = 0;

            switch (c)
            {
                case 'I':
                    result = 1;
                    break;
                case 'V':
                    result = 5;
                    break;
                case 'X':
                    result = 10;
                    break;
                case 'L':
                    result = 50;
                    break;
                case 'C':
                    result = 100;
                    break;
                case 'D':
                    result = 500;
                    break;
                case 'M':
                    result = 1000;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
