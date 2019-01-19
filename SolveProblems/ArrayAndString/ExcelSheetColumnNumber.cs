using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /* 
     Given a column title as appear in an Excel sheet, return its corresponding column number.

        For example:

            A -> 1
            B -> 2
            C -> 3
            ...
            Z -> 26
            AA -> 27
            AB -> 28 
            ...
        Example 1:

        Input: "A"
        Output: 1
        Example 2:

        Input: "AB"
        Output: 28
        Example 3:

        Input: "ZY"  26*26 + 25
        Output: 701
     * 
     * AAA = (1*26 + 1)*26 + 1
     * BCZ = (2*26 + 3)*26 + 26
     */
    class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            int columnNum = 0;

            for (int i = 0; i < s.Length -1; i++)
            {
                columnNum = 26*(columnNum +  GetIntForChar(s[i])) ;
            }

            return columnNum + GetIntForChar(s[s.Length - 1]);
        }

        private int GetIntForChar(char c)
        {
            int result = 0;

            switch (c)
            {
                case 'A':
                    result = 1;
                    break;
                case 'B':
                    result = 2;
                    break;
                case 'C':
                    result = 3;
                    break;
                case 'D':
                    result = 4;
                    break;
                case 'E':
                    result = 5;
                    break;
                case 'F':
                    result = 6;
                    break;
                case 'G':
                    result = 7;
                    break;
                case 'H':
                    result = 8;
                    break;
                case 'I':
                    result = 9;
                    break;
                case 'J':
                    result = 10;
                    break;
                case 'K':
                    result = 11;
                    break;
                case 'L':
                    result = 12;
                    break;
                case 'M':
                    result = 13;
                    break;
                case 'N':
                    result = 14;
                    break;
                case 'O':
                    result = 15;
                    break;
                case 'P':
                    result = 16;
                    break;
                case 'Q':
                    result = 17;
                    break;
                case 'R':
                    result = 18;
                    break;
                case 'S':
                    result = 19;
                    break;
                case 'T':
                    result = 20;
                    break;
                case 'U':
                    result = 21;
                    break;
                case 'V':
                    result = 22;
                    break;
                case 'W':
                    result = 23;
                    break;
                case 'X':
                    result = 24;
                    break;
                case 'Y':
                    result = 25;
                    break;
                case 'Z':
                    result = 26;
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            return result;
        }
    }
}
