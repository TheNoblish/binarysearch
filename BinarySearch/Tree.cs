using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Tree
    {
        public Node root;

        public Tree(int value)
        {
            
            this.root = new Node(value);
            
        }

        public void AddNode(int value)
        {
            root.AddChild(value);
        }
    }
}
