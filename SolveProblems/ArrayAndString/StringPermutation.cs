using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /// <summary>
    /// Given two strings, write a method to decide if one is a permutation of the other
    /// </summary>
    class StringPermutation
    {
        /// <summary>
        /// Given two strings, write a method to decide if one is a permutation of the other
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool CheckTwoStringsArePermutationOfEachOther(string str1, string str2)// Wrong implementation. Code does not work
        {
            if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) || str1.Length != str2.Length)
            {
                return false;
            }


            for(int index = 0; index < str1.Length; index ++)
            {
                if(!str2.ToUpper().Contains(str1[index].ToString().ToUpper()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckAnagram(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
            {
                return false;
            }
           
            int[] letters = new int[1 << 8];// size is 256
            foreach(char c in s.ToCharArray())
            {
                letters[c] = letters[c] + 1;
            }

            foreach(char c in t.ToCharArray())
            {
                letters[c] = letters[c] - 1;
            }

            foreach(int c in letters)
            {
                if (c != 0)
                    return false;
            }

            return true;
        }
    }
}
