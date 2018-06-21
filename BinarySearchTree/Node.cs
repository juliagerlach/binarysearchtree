using System;

namespace BinarySearchTree
{
    public class Node
    {
        //private member variables
        public int data;
        public Node leftChild;
        public Node rightChild;
        
        public void DisplayNode()
        {
            Console.Write(data + " ");
        }

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }

       
    }
}
