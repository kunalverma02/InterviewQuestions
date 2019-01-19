using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /// <summary>
    /// Write a Method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional
    /// characters, and that you are given the "true" length of the string.
    /// "My Name is John    " to "My%20Name%20is%20John"
    /// </summary>
    class URLify
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stringLength"></param>
        /// <returns></returns>
        public string ReplaceSpaceWithPercent20(string str, int stringLength)
        {
            char[] splittedStringChar = str.ToCharArray(0, stringLength);
            int spaceCount =0;

            for (int i = 0; i < stringLength; i++ )
            {
                if(splittedStringChar[i] == ' ')
                {
                    spaceCount++;
                }
            }

            int insertIndex = stringLength + 2 * spaceCount -1;
            char[] newCharArray = new char[insertIndex +1]; 

            for (int i = stringLength -1; i >=0; i--)
            {
                char tempChar = splittedStringChar[i];
                if(tempChar == ' ')
                {
                    newCharArray[insertIndex--] = '0';
                    newCharArray[insertIndex--] = '2';
                    newCharArray[insertIndex--] = '%';
                }
                else
                {
                    newCharArray[insertIndex--] = tempChar;
                }
            }
            return new string(newCharArray);
        }
    }
}
