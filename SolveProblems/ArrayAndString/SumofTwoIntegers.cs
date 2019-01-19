using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class SumofTwoIntegers
    {
        /* Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.

        Example 1:
        Input: a = 1, b = 2
        Output: 3
        
        Example 2:
        Input: a = -2, b = 3
        Output: 1
         */
        public int GetSum(int a, int b)
        {
            int sum = a ^ b;
            int carry = a & b;

            if (carry == 0) return sum;
            return GetSum(sum, carry << 1);
        }
    }
}
