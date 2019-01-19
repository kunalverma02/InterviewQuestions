using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Sorting
{
    /// <summary>
    /// Insertion Sort is in Place sort(No need of any extra storage). Other examples of In-place sort are Selection Sort, Bubble Sort, Shell Sort
    /// It has space complexity of O(1).
    /// Time complexity of Bubble sort in O(n^2) in the worst case
    /// Basic Operation in sorting : Comparisions and record movement
    /// Sort Efficiency : Data Sensitive method. Run time depends on initial order of elements. Input data can be in sorted order, random order or reverse sorted order.
    /// Sort Stability: 
    /// 1)Stable Sort: Maintain the relative order of duplicate elements
    /// 2)Unstable Sort: Change the relative order of duplicate elements
    class InsertionSort
    {
        /// <summary>
        /// Here insertion technique is used to sort the array. Array is divided between sorted and unsorted array. for first pass sorted array is of length one. In nth pass sorted array length of sorted array is n.
        /// Insertion Sort is data sensitive sort. So, time complexity depends on input data.
        /// If data is sorted: O(n)
        /// If data is in reverse sorted order : O(n^2)
        /// If data is in random order : O(n^2)
        /// InsertionSort is stable sort
        /// InPlace sort
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] InsertionSortMethod(int [] input)
        {
           
            int temp, i,j;
            for ( i = 1; i < input.Length; i++)
            {
                temp = input[i]; ;
                for (j = i-1 ; j >=0 && input[j ]> temp; j--)
                {
                    input[j + 1] = input[j];
                }

                input[j + 1] = temp;
            }

            return input;
        }
    }
}
