using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /* Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Note that an empty string is also considered valid.

        Example 1:
        Input: "()"
        Output: true
        
     * Example 2:
        Input: "()[]{}"
        Output: true
        
     * Example 3:
        Input: "(]"
        Output: false
        
     * Example 4:
        Input: "([)]"
        Output: false
        
     * Example 5:
        Input: "{[]}"
        Output: true 
     */
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s == null)
                return false;
            if (s == "")
            {
                return true;
            }
            foreach (char c in s.ToCharArray())
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == '}' || c == ')' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;
                    else if (stack.Peek() == '{' && c == '}')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '(' && c == ')')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && c == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (stack.Count == 0)
                return true;

            return false;

        }
    }
}
