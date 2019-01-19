using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class RepeatedAndMissingNumber
    {
        //This is without using extra memory
        public List<int> FindRepeatedAndMissingNumber(List<int> A)
        {

            long sum1 = 0;
            long sum2 = 0;
            int missingNum = 0;
            for (int i = 1; i <= A.Count; i++)
            {
                sum1 = sum1 + Convert.ToInt64(A[i - 1]);
                sum2 = sum2 + Convert.ToInt64(i);
                if (!A.Contains(i))
                {
                    missingNum = i;
                }
            }



            //sum2 = ((A.Count + 1) * A.Count) / 2;
            int dup = Convert.ToInt32(sum1 - sum2 + missingNum);

            // Sum(Actual) - Sum(1…N)  + B= A 

            return new List<int>() { dup, missingNum };
        }


        public List<int> RepeatedAndMissingNumberUsingHashtable(List<int> A)
        {

            long sumActual = 0;
            long sumNumber = 0;
            int missingNum = 0;
            int dup = 0;
            Hashtable hash = new Hashtable();
          

            for (int i = 1; i <= A.Count; i++)
            {
                sumActual = sumActual + Convert.ToInt64(A[i - 1]);
                sumNumber = sumNumber + Convert.ToInt64(i);
                if (hash.Contains(A[i - 1]))
                {
                    dup = A[i - 1];
                }
                else
                {
                    hash.Add(A[i - 1], i);
                }
            }



            //sum2 = ((A.Count + 1) * A.Count) / 2;
            missingNum = Convert.ToInt32(sumNumber - sumActual + dup);

            // Sum(Actual) - Sum(1…N)  + B= A 

            return new List<int>() { dup, missingNum };
        }

        public List<int> RepeatedAndMissingNumberUsingDictionary(List<int> A)
        {

            long sumActual = 0;
            long sumNumber = 0;
            int missingNum = 0;
            int dup = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();


            for (int i = 1; i <= A.Count; i++)
            {
                sumActual = sumActual + Convert.ToInt64(A[i - 1]);
                sumNumber = sumNumber + Convert.ToInt64(i);
                if (dictionary.ContainsKey(A[i - 1]))
                {
                    dup = A[i - 1];
                }
                else
                {
                    dictionary.Add(A[i - 1], i);
                }
            }

            //sum2 = ((A.Count + 1) * A.Count) / 2;
            missingNum = Convert.ToInt32(sumNumber - sumActual + dup);

            // Sum(Actual) - Sum(1…N)  + B= A 

            return new List<int>() { dup, missingNum };
        }
    }
}
