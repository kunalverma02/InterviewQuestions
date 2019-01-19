using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class FirstUniqueCharacterinaString
    {
        public int FindFirstUniqueCharacterinaString(string s)
        {

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            Dictionary<char, int> dDuplicate = new Dictionary<char, int>();
            

            for (int i = 0; i < s.Length; i++ )
            {
                if(dictionary.ContainsKey(s[i]))
                {
                    if (!dDuplicate.ContainsKey(s[i]))
                        dDuplicate.Add(s[i], i);
                }
                else
                {
                    dictionary.Add(s[i], i);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
               if(!dDuplicate.ContainsKey(s[i]))
               {
                   return i;
               }
            }
                return -1;
        }
    }
}
