using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /// <summary>
    /// Given a string write a function to check if it is a permutation of a palindrome. Palindrome is word or phrase that is same forward and backward.
    /// </summary>
    class PalindromePermutation
    {
        /// <summary>
        /// if string length is even then every character will come even times. Assuming no space.
        /// if string length is odd then every character will come even times except the middle one. Assuming no space.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool CheckIfPalindrome(string str)
        {

            string[] strArray = str.ToUpper().Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != "")
                {
                    sb.Append(strArray[i]);
                }
            }

            string strPalindrome = sb.ToString();
            int stringLength = strPalindrome.Length;
            if (stringLength < 3)
            {
                return false;
            }

            int numberOfOddChar = 0;
            List<char> uniqueCharList = new List<char>();

            for (int i = 0; i < strPalindrome.Length; i++)
            {
                if(!uniqueCharList.Contains(strPalindrome[i]))
                {
                    uniqueCharList.Add(strPalindrome[i]);
                }
            }

            for (int i = 0; i < uniqueCharList.Count; i++)
            {
                char c = uniqueCharList[i];
                int count = strPalindrome.Split(c).Length -1;
                if (count % 2 != 0)
                {
                    numberOfOddChar++;
                }

            }
            if (stringLength % 2 == 0)
            {
                if (numberOfOddChar > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (numberOfOddChar == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
