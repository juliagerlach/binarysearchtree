using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;
        
        public BinarySearchTree()
        {
            root = null;
        }

        public void CreateTree()
        {
            root = new Node('P');
            root.leftChild = new Node('Q');
            root.rightChild = new Node('R');
            root.leftChild.leftChild = new Node('A');
            root.leftChild.rightChild = new Node('B');
            root.rightChild.leftChild = new Node('X');
        }

        public void Insert(int i)
        {
            Node newNode = new Node(i);
            newNode.data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            break;
                        }

                        else
                        {
                            current = current.rightChild;
                            if (current == null)
                            {
                                parent.rightChild = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public virtual void Clear()
        {
            root = null;
        }
    }
}
