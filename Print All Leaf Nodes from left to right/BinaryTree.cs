using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_All_Leaf_Nodes_from_left_to_right_iterative
{
    public class BinaryTree
    {
        public Node Root;

        public Stack<Node> GetLeafLeftToRight()
        {
            // Store all the nodes
            Stack<Node> s1 = new Stack<Node>();
            // Store all the leaf nodes
            Stack<Node> s2 = new Stack<Node>();

            if (Root != null)
            {
                s1.Push(Root);
            }

            while(s1.Count > 0)
            {
                var current = s1.Pop();

                if(current.Left != null)
                {
                    s1.Push(current.Left);
                }

                if (current.Right != null)
                {
                    s1.Push(current.Right);
                }

                if(current.Left == null && current.Right == null)
                {
                    s2.Push(current);
                }
            }

            return s2;
        }

        public void PrintNode(Stack<Node> nodes)
        {
            while(nodes.Count > 0)
            {
                var current = nodes.Pop();
                Console.Write(current.Data + " ");
            }
        }
    }
}
