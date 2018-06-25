using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            AddNode(ref root, newNode);
        }
        public void AddNode(ref Node<T> currentNode, Node<T> newNode)
        {
            if (currentNode == null)
            {
                currentNode = newNode;
            }
            else
            {
                if (newNode.value.CompareTo(currentNode.value) < 0)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                    }
                    else
                    {
                        AddNode(ref currentNode.left, newNode);
                    }
                }
                else if (newNode.value.CompareTo(currentNode.value) > 0)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                    }
                    else
                    {
                        AddNode(ref currentNode.right, newNode);
                    }
                }
            }
        }
        public Node<T> Search(T value)
        {
            if (root == null)
            {
                return root;
            }
            else
            {
                if (root.value.CompareTo(value) == 0)
                {
                    return root;
                }
                else
                {
                    return SearchNode(root, value);
                }
            }
        }
        public Node<T> SearchNode(Node<T> currentNode, T value)
        {
            if (currentNode == null)
            {
                return currentNode;
            }
            else
            {
                if (currentNode.value.CompareTo(value) == 0)
                {
                    return currentNode;
                }
                else if (currentNode.value.CompareTo(value) < 0)
                {
                    return SearchNode(currentNode.right, value);
                }
                else
                {
                    return SearchNode(currentNode.left, value);
                }
            }
        }
       
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("There is nothing in this tree");
            }
            else
            {
                Node<T> currentNode = root;
                DisplayNode(root);
            }
        }
        public void DisplayNode(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine("Value: {0}", node.value);
                DisplayNode(node.left);
                DisplayNode(node.right);
            }
        }
    }
}
