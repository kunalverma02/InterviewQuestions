using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.BinaryTree
{
    class BTNode
    {
        public char value;
        public BTNode lChild;
        public BTNode rChild;

        public BTNode(char val)
        {
            this.value = val;
        }
    }
}
