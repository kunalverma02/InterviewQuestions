using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Sorting
{
    /// <summary>
    /// Bubble Sort is in Place sort(No need of any extra storage). Other examples of In-place sort are Selection Sort, Insertion Sort, Shell Sort
    /// It has space complexity of O(1).
    /// Time complexity of Bubble sort in O(n^2) in the worst case
    /// Basic Operation in sorting : Comparisions and record movement
    /// Sort Efficiency : Data Sensitive method. Run time depends on initial order of elements. Input data can be in sorted order, random order or reverse sorted order.
    /// Sort Stability: 
    /// 1)Stable Sort: Maintain the relative order of duplicate elements
    /// 2)Unstable Sort: Change the relative order of duplicate elements
    /// </summary>
    class BubbleSort
    {
        /// <summary>
        /// compare adjecent elements and move the larger element toward larger index. In first pass first A0 and A1 will be compared. 
        /// If A0 is greater than A1 then make a swap. Next A1 and A2 will be comapre and so on till An-2 and An-1 will be compared. 
        /// Bubble Sort is data sensitive sort. So, time complexity depends on input data.
        /// If data is sorted: O(n)
        /// If data is in reverse sorted order : O(n^2)
        /// If data is in random order : O(n^2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int [] BubbleSortMethod(int [] input)
        {
            int temp, swaps;
            for (int i = 0; i < input.Length; i++)
            {

                swaps = 0;
                for (int j = 0; j < input.Length -1 -i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j +1] = temp;
                        swaps++;
                    }
                }
                if (swaps == 0)
                    break;
            }

            return input;
        }
    }
}
