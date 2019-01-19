using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Sorting
{
    /// <summary>
    /// Selection Sort is in Place sort(No need of any extra storage). Other examples of In-place sort are Bubble Sort, Insertion Sort, Shell Sort
    /// It has space complexity of O(1).
    /// Time complexity of Selection sort in O(n^2) in all best, worst or average case.
    /// Basic Operation in sorting : Comparisions and record movement
    /// Sort Efficiency : Data Sensitive method. Run time depends on initial order of elements. Input data can be in sorted order, random order or reverse sorted order.
    /// Sort Stability: 
    /// 1)Stable Sort: Maintain the relative order of duplicate elements
    /// 2)Unstable Sort: Change the relative order of duplicate elements
    /// </summary>
    class SelectionSort
    {
        /// <summary>
        /// Selection sort: in the first iteration we find minimum value in the given list and swap this minm value with element at index 0 position.
        ///                 In next step we find the second minm value and swap this with index 1 position. We keep doing this till list get sorted.
        /// Not a data sensitive sort : Due to this time complexity of Selection sort in O(n^2) in all best, worst or average case scenarios.  
        /// Less Data Movement : only one data move in one iteration
        /// In Place Sort : Space complexity on O(1)
        /// Unstable Sort : Might change the relative order of duplicate elements
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] SelectionSortMethod(int [] input)
        {
            for(int i=0; i< input.Length; i++)
            {
                //int minmVal = input[i];
                int minIndex = i;
                int temp;
                for(int j = i + 1; j<input.Length; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        input[minIndex] = input[j];
                        minIndex = j;
                    }
                }
                temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }

            return input;
        }
    }
}
