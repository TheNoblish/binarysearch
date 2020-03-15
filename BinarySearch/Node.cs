using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Node
    {
        public int value;
        public Node parent;
        public Node rightChild;
        public Node leftChild;

        public Node (int value)
        {
            
            this.value = value;
            
        }

        public void AddChild(int value)
        {
            if (value > this.value)
            {
                if (rightChild == null)
                {
                    rightChild = new Node(value);
                }
                else
                {
                    rightChild.AddChild(value);
                }
            }
            else if (value < this.value)
            {
                if (leftChild == null)
                {
                    leftChild = new Node(value);
                }
                else
                {
                    leftChild.AddChild(value);
                }
            }
            else
            {
                Console.WriteLine("ERROR #1 : Not a valid value or value is already in tree");
            }
        }
        public void Print(string indent, bool last)
        {
            
            if (last)
            {
                Console.WriteLine(indent + "└─" + value);
                indent += "  ";
            }
            else
            {
                Console.WriteLine(indent+ "├─" + value);
                indent += "| ";
            }
            

            var children = new List<Node>();
            if (rightChild != null)
                children.Add(rightChild);
            if (leftChild != null)
                children.Add(leftChild);
            

            for (int i = 0; i < children.Count; i++)
                children[i].Print(indent, i == children.Count - 1);
        }
        public List<string> Find(int value)
        {
            List<string> path = new List<string>();
            if (value == this.value)
            {
                path.Add("Found");
            }
            else
            {
                if(value > this.value)
                {
                    path.Add("Right");
                    rightChild.Find(value).ForEach(path.Add);
                }
                else if (value < this.value)
                {
                    path.Add("Left");
                    leftChild.Find(value).ForEach(path.Add);
                }
            }
            return path;
        }

        public List<int> Remove(int value,bool removed)
        {
            List<int> values = new List<int>();
            if (value == this.value)
            {

            }

            return values;
        }
    }
}
