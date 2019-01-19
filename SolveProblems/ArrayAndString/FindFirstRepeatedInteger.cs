using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class FindFirstRepeatedInteger
    {
        public int? FindFirstRepeatedIntegerUsingHashTable(int[] array)
        {
            
            Hashtable hashtable = new Hashtable();
            
            for (int i = 0; i < array.Length; i++ )
            {
                if (hashtable.Contains(array[i]))
                {
                    return array[i];
                }
                else
                {
                    hashtable.Add(array[i], i);
                }
                
            }
                return null;
        }

        public int? FindFirstRepeatedIntegerUsingList(int[] array)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (list.Contains(array[i]))
                {
                    return array[i];
                }
                else
                {
                    list.Add(array[i]);
                }
            }
            return null;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable hashTable = new Hashtable();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashTable.ContainsValue(target - nums[i]))
                {
                    result[0] = hashTable.Keys.OfType<int>().FirstOrDefault(x => Convert.ToInt32(hashTable[x]) == (target - nums[i]));
                    result[1] = i;
                    return result;
                }
                else
                {
                    hashTable.Add(i, nums[i]);
                }
            }
          
            return result;
        }
    }
}
