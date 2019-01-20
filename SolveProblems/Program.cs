using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveProblems.ArrayAndString;
using SolveProblems.LinkedList;
using SolveProblems.StackAndQueue;
using SolveProblems.Recursion;
using SolveProblems.Sorting;
using SolveProblems.DynamicProgramming;
using SolveProblems.DynamicProgramming.UnBoundedKnapsack;

namespace SolveProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindFirstRepeatedInteger firstRepeatedInteger = new FindFirstRepeatedInteger();
            //Console.WriteLine(firstRepeatedInteger.TwoSum(new int[]{2, 7, 11, 15}, 9));
            //Console.WriteLine(firstRepeatedInteger.FindFirstRepeatedIntegerUsingHashTable(new int[] { 2, 3, 5, 7, 5, 11, 15 }));
            //CheckIfPalindrome();
            //List<int> A = new List<int>()
            //{
            //    389, 299, 65, 518, 361, 103, 342, 406, 24, 79, 192, 181, 178, 205, 38, 298, 218, 143, 446, 324, 82, 41, 312, 166, 252, 59, 91, 6, 248, 395, 157, 332, 352, 57, 106, 246, 506, 261, 16, 470, 224, 228, 286, 121, 193, 241, 203, 36, 264, 234, 386, 471, 225, 466, 81, 58, 253, 468, 31, 197, 15, 282, 334, 171, 358, 209, 213, 158, 355, 243, 75, 411, 43, 485, 291, 270, 25, 100, 194, 476, 70, 402, 403, 109, 322, 421, 313, 239, 327, 238, 257, 433, 254, 328, 163, 436, 520, 437, 392, 199, 63, 482, 222, 500, 454, 84, 265, 508, 416, 141, 447, 258, 384, 138, 47, 156, 172, 319, 137, 62, 85, 154, 97, 18, 360, 244, 272, 93, 263, 262, 266, 290, 369, 357, 176, 317, 383, 333, 204, 56, 521, 502, 326, 353, 469, 455, 190, 393, 453, 314, 480, 189, 77, 129, 439, 139, 441, 443, 351, 528, 182, 101, 501, 425, 126, 231, 445, 155, 432, 418, 95, 375, 376, 60, 271, 74, 11, 419, 488, 486, 54, 460, 321, 341, 174, 408, 131, 115, 107, 134, 448, 532, 292, 289, 320, 14, 323, 61, 481, 371, 151, 385, 325, 472, 44, 335, 431, 187, 51, 88, 105, 145, 215, 122, 162, 458, 52, 496, 277, 362, 374, 26, 211, 452, 130, 346, 10, 315, 459, 92, 531, 467, 309, 34, 281, 478, 477, 136, 519, 196, 240, 12, 288, 302, 119, 356, 503, 527, 22, 27, 55, 343, 490, 127, 444, 308, 354, 278, 497, 191, 294, 117, 1, 396, 125, 148, 285, 509, 208, 382, 297, 405, 245, 5, 330, 311, 133, 274, 275, 118, 463, 504, 39, 99, 442, 337, 169, 140, 104, 373, 221, 499, 413, 124, 510, 159, 465, 80, 276, 83, 329, 524, 255, 387, 259, 397, 491, 517, 23, 4, 230, 48, 349, 412, 142, 114, 487, 381, 164, 35, 67, 498, 73, 440, 108, 226, 96, 132, 144, 207, 235, 33, 69, 128, 236, 364, 198, 475, 173, 493, 150, 90, 515, 111, 68, 232, 340, 112, 526, 492, 512, 495, 429, 146, 336, 17, 350, 251, 7, 184, 76, 380, 359, 293, 19, 49, 345, 227, 212, 430, 89, 474, 279, 201, 398, 347, 273, 37, 185, 177, 102, 304, 295, 422, 94, 426, 514, 116, 183, 180, 494, 42, 305, 152, 390, 30, 247, 451, 32, 388, 331, 78, 424, 368, 394, 188, 306, 449, 8, 214, 120, 179, 280, 511, 409, 338, 153, 507, 370, 461, 217, 161, 483, 147, 242, 86, 417, 268, 71, 462, 420, 167, 513, 379, 307, 522, 435, 113, 296, 457, 525, 45, 529, 423, 427, 2, 438, 64, 316, 46, 40, 13, 516, 367, 233, 110, 318, 250, 283, 216, 186, 310, 237, 377, 365, 175, 479, 378, 66, 414, 473, 165, 210, 50, 348, 372, 363, 339, 20, 168, 284, 415, 505, 206, 53, 223, 434, 202, 123, 399, 400, 135, 269, 428, 219, 456, 28, 464, 267, 489, 98, 391, 195, 366, 300, 484, 533, 229, 213, 149, 160, 256, 303, 530, 301, 29, 404, 344, 401, 220, 287, 9, 407, 170, 450, 523, 249, 72, 410, 3, 21, 200, 260 
            //};
           // double asas =Convert.ToDouble(  3)/Convert.ToDouble(2);
            TestRodCutting();
            TestUnboundedKnapsack();

            TestMergeTwoLinkedList();
            TestStockSell1();
            TestExcelSheetColumnNumber();
            TestSumofTwoIntegers();
            TestMoveZeros();
            TestFindDuplicates();
            int[] arr = new int[20];
            TestMergeTwoSortedArray();
            TestInsertionSort();
            TestBubbleSort();
            TestSelectionSort();
            TestRecursion();
            TestMaximumAbsoluteDifference();
            TestMaxSubSet();
            TestMaxSubArray();
            List<int> A = new List<int>()
            {
                9,9,9,9 
            };
            List<int> B = PlusOne(A);
           // A.Sort();
            //List<int> B = repeatedNumber(A);
            TestRecursion();

            TestQueueL();
            FizzBuzz(3);
           //bool check = CheckStringPermutation();
            LinkedList<int> mylist = new LinkedList<int>();
           

            SinglyLinkedList<int> myLinkedList = new SinglyLinkedList<int>();
            myLinkedList.Append(1);
            myLinkedList.Append(2);
            myLinkedList.Append(3);
            myLinkedList.Append(4);
            myLinkedList.Append(5);
            //myLinkedList.Append(6);
            //myLinkedList.Append(7);
            //myLinkedList.Append(8);
            //myLinkedList.Append(1);

            //myLinkedList.InsertAtStart(99);

            myLinkedList.Reverse();
            myLinkedList.FindKthToLastElement1(1);
            myLinkedList.Display();

            myLinkedList.RemoveDuplicatesFromLinkedList();
            Console.WriteLine("--------------------------------------");
            myLinkedList.Display();
            Console.WriteLine(myLinkedList.Search(12));

            Console.ReadLine();
           
        }
        private static void TestRodCutting()
        {
            RodCutting ks = new RodCutting();
            int[] lengths = { 1, 2, 3, 4, 5 };
            int[] prices = { 2, 6, 7, 10, 13 };
            Console.WriteLine(ks.SolveRodCutting(lengths, prices, 5));
            Console.WriteLine(ks.SolveRodCutting(lengths, prices, 6));
        }
        private static void TestUnboundedKnapsack()
        {
            UnboundedKnapsack ks = new UnboundedKnapsack();
            int[] profits = {15, 50, 60, 90};
            int[] weights = {1, 3, 4, 5};
            Console.WriteLine(ks.GetMaximumProfit(profits, weights, 8));
            Console.WriteLine(ks.GetMaximumProfit(profits, weights, 6));
        }
        private static void TestMergeTwoLinkedList()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            MergeTwoLinkedList m = new MergeTwoLinkedList();
            ListNode result = m.MergeTwoLists(l1, l2);
        }
        private static void TestStockSell1()
        {
            SellAStock1 s = new SellAStock1();
            int result = s.MaxProfit2(new int[6] {3,2,6,5,0,3});
        }
        private static void TestExcelSheetColumnNumber()
        {
            ExcelSheetColumnNumber d = new ExcelSheetColumnNumber();
            int result = d.TitleToNumber("AAA");
        }
        private static void TestSumofTwoIntegers()
        {
            SumofTwoIntegers d = new SumofTwoIntegers();
            int result = d.GetSum(25, 39);
        }
        private static void TestMoveZeros()
        {
            MoveZero mz = new MoveZero();
            //int[] result = mz.MoveZeroes(new int[3] { 0, 0, 1 });
            int[] result = mz.MoveZeroes(new int[28] { 0, 0, 1, 4, 3, 2, 7, 8,0,12,5,8,16,0,31,0,54,98,0,1,2,3,5,6,0,10,100,6 });

        }

        private static void TestFindDuplicates()
        {
            FindAllDuplicatesInAnArray d = new FindAllDuplicatesInAnArray();
            IList<int> result = d.FindDuplicatesWithoutExtraMemory(new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 });
        }

        private static void TestMergeTwoSortedArray()
        {
            MergeSort m = new MergeSort();
            int[] result = m.MergeSortedArray(new int[3] { 2,4,6}, new int[3]{1,2,3});
        }

        private static void TestInsertionSort()
        {
            InsertionSort i = new InsertionSort();
            int[] result = i.InsertionSortMethod(new int[5] { 4, 3, -1, 7, 2 });
        }
        private static void TestBubbleSort()
        {
            BubbleSort b = new BubbleSort();
            int[] result = b.BubbleSortMethod(new int[5] { 4, 3, -1, 7, 2 });
        }
        private static void TestSelectionSort()
        {
            SelectionSort s = new SelectionSort();
            int[] result = s.SelectionSortMethod(new int[5] { 4, 3, -1, 7, 2 });
        }
        private static void TestRecursion()
        {
            RecursionProblems r = new RecursionProblems();
            r.ReverseStringRecursive("Kunal");
            int res = r.ReverseNumberRecursion(123);
            Console.WriteLine(res);
        }

        private static bool CheckStringPermutation()
        {
            StringPermutation sp = new StringPermutation();
            string str1 = "kunal"; 
            string str2 = "unakl";
            return sp.CheckTwoStringsArePermutationOfEachOther(str1, str2);
        }
        private static string ReplaceSpaceWithPercent20()
        {
            URLify uf = new URLify();
            string str = "My name is Kunal.   ";
            return uf.ReplaceSpaceWithPercent20(str, 17);
        }
        private static void CheckIfPalindrome()
        {
            PalindromePermutation pp = new PalindromePermutation();
            Console.WriteLine(pp.CheckIfPalindrome("Step on no pets"));
            Console.ReadLine();
        }
        private static void TestStackL()
        {
            StackL<int> stackL = new StackL<int>();
            stackL.Push(1);
            stackL.Push(10);
            stackL.Push(100);
            stackL.Push(1000);
            stackL.Push(10000);
            stackL.DisPlay();

            Console.WriteLine("Let's Delete from stack");
            Console.WriteLine("item " + stackL.Pop() + " is deleted");
            Console.WriteLine("------------------------------------------");
            stackL.DisPlay();


        }

        private static void TestQueueL()
        {
            QueueL<int> queueL = new QueueL<int>();
            queueL.Enqueue(1);
            queueL.Enqueue(10);
            queueL.Enqueue(100);
            queueL.Enqueue(1000);
            queueL.Enqueue(10000);
            queueL.Display();

            Console.WriteLine("Let's Delete from stack");
            Console.WriteLine("item " + queueL.Dequeue() + " is deleted");
            Console.WriteLine("------------------------------------------");
            queueL.Display();


        }

        public static IList<string> FizzBuzz(int n)
        {

            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else
                {
                    result.Add(i.ToString());
                }

            }
            return result;

        }

        public static string ReverseString(string s)
        {

            int loopCount = s.Length / 2;
            int length = s.Length;
            char[] reverseString = new char[length];

            for (int i = 0; i <= loopCount; i++)
            {
                reverseString[i] = s[length - i - 1];
                reverseString[length - i - 1] = s[i];
            }
            return new String(reverseString);

        }

        public static bool IsAlienSorted(string[] words, string order)
        {
            bool isSorted = false;
            bool hasSameOrder = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (i < words.Length - 1)
                {
                    int firstLength = words[i].Length;
                    int secondLength = words[i + 1].Length;

                    if(firstLength>=secondLength)
                    {
                        for(int j=0; j< secondLength; j++)
                        {
                           if( order.IndexOf(words[i][j]) < order.IndexOf(words[i +1][j]) )
                           {
                               return false;
                           }
                           else if (order.IndexOf(words[i][j]) == order.IndexOf(words[i + 1][j]))
                           {
                               hasSameOrder = true;
                           }
                           else
                           {
                               isSorted = true;
                               break;
                           }

                           if (!isSorted && hasSameOrder)
                           {
                               isSorted = true;
                           }
                           
                        }
                    }

                    if (firstLength < secondLength)
                    {
                        for (int j = 0; j < firstLength; j++)
                        {
                            if (order.IndexOf(words[i][j]) < order.IndexOf(words[i + 1][j]))
                            {
                                return false;
                            }
                            else if (order.IndexOf(words[i][j]) == order.IndexOf(words[i + 1][j]))
                            {
                                hasSameOrder = true;
                            }
                            else
                            {
                                isSorted = true;
                                break;
                            }

                            if(!isSorted && hasSameOrder)
                            {
                                isSorted = false;
                            }
                        }

                    }
                }
            }

            return isSorted; 
        }
        public bool CanReorderDoubled(int[] A)
        {
            if(A.Length == 0 || A.Length % 2 != 0)
            {
                return false;
            }
            List<int> list = new List<int>();

            for(int i =0; i<A.Length; i ++)
            {
                if (!list.Contains(A[i]))
                {
                    if (A.Contains(2 * A[i]))
                    {
                        list.Add(A[i]);
                        list.Add(2 * A[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void TestMaxSubArray()
        {
            MaxSubArraySum s = new MaxSubArraySum();
            s.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

        }


        private static void TestMaxSubSet()
        {
            MaxSubArraySum s = new MaxSubArraySum();
            s.Maxset(new List<int>() {  756898537, -1973594324, -2038664370, -184803526, 1424268980 });

        }

        private static void TestMaximumAbsoluteDifference()
        {
            MaximumAbsoluteDifference s = new MaximumAbsoluteDifference();
            s.FindMaximumAbsoluteDifference(new List<int>() { 1, 3, -1 });

        }

        public static List<int> PlusOne(List<int> A)
        {
            
            List<int> B = new List<int>();
            int firstNonZeroIndex = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] != 0)
                {
                    firstNonZeroIndex = i;
                    break;
                }
            }
            int firstNon9 = -1;
            for (int i = A.Count - 1; i >= firstNonZeroIndex; i--)
            {

                if (A[i] != 9)
                {
                    firstNon9 = i;
                    break;
                }
                
                
            }

            for (int i = firstNonZeroIndex; i < A.Count; i++)
            {
                if (firstNon9 == -1 && i == firstNonZeroIndex)
                {
                    B.Add(1);
                    B.Add(0);
                }
                else if (i == firstNon9)
                {
                    B.Add(A[i] + 1);
                }
                else if (i > firstNon9)
                {
                    B.Add(0);
                }
                else
                {
                    B.Add(A[i]);
                }
            }


            return B;
        }

    }
}
