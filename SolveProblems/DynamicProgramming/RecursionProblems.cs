using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Recursion
{
    class RecursionProblems
    {
        public int SumOfaGivenNumber(int n)
        {
            if (n / 10 == 0)
                return n;

            return SumOfaGivenNumber(n / 10) + n % 10;
        }

        /// <summary>
        /// 2456 --> 6542
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ReverseNumberIteration(int n)
        {
            int result =0;
            
            while(n>0)
            {
                result = result * 10 + n % 10;
                n = n / 10;
            }

            return result;
        }
        int resultG = 0;
        int baseNum = 1;
        public int ReverseNumberRecursion(int n)
        {
            if(n> 0)
            {
                ReverseNumberRecursion(n / 10);
                resultG = resultG + baseNum * (n % 10);
                baseNum *= 10;
            }

            return resultG;
        }

        string reverseString = string.Empty;
        public string ReverseStringRecursive(string s)
        {
           
           if(s!= null && s.Length>0)
           {
               string lastChar = s.Substring(s.Length - 1);
               reverseString = reverseString + lastChar;
               ReverseStringRecursive(s.Substring(0, s.Length - 1));
           }

           return reverseString;
        }


    }
}
