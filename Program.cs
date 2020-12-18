using System;

namespace BSTEmplementation
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public void print()
        {
            Console.Write("(");
            Console.Write(data);
            Console.Write(")");
        }
    }
    //The Binary search tree class
    class BST
    {
        public Node root;
        public BST()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        //Insert elements in the Tree
        public void Insert(int item)
        {
            Node newNode = new Node();
            newNode.data = item;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (item < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }

        }
        //Pre-order print order
        public void PreOrder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.data + " ");
                PreOrder(Root.left);
                PreOrder(Root.right);
            }
        }
        //In-order print method 
        public void InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.left);
                Console.Write(Root.data + " ");
                InOrder(Root.right);
            }
        }
        //Post-order print method
        public void PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.left);
                PostOrder(Root.right);
                Console.Write(Root.data + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] agrs)
        {
            //The BST construction
            BST myTree = new BST();

            myTree.Insert(42);
            myTree.Insert(56);
            myTree.Insert(91);
            myTree.Insert(28);
            myTree.Insert(38);
            myTree.Insert(65);
            myTree.Insert(69);
            myTree.Insert(73);
            myTree.Insert(84);

            Console.WriteLine("InOrder Traversal : ");
            myTree.InOrder(myTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("PreOrder Traversal : ");
            myTree.PreOrder(myTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal : ");
            myTree.PostOrder(myTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
        }
    }
}
