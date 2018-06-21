using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;
        public string action;

        public BinarySearchTree()
        {
            root = null;
        }

        public void CreateTree()
        {
            root = new Node(50);
            root.leftChild = new Node(25);
            root.rightChild = new Node(75);
            root.leftChild.leftChild = new Node(15);
            root.leftChild.rightChild = new Node(35);
            root.rightChild.leftChild = new Node(60);
            root.rightChild.rightChild = new Node(80);
        }

        public object SearchTree(Node node)
        {
            Console.WriteLine("Please enter a number you'd like to search for, and then press 'enter'.");
            string searchNode = Console.ReadLine();

            Node current = root;
            if (current == null)
                return "Not found";
            if (Convert.ToInt32(node) == Convert.ToInt32(current.data))
                return node;
            if (Convert.ToInt32(node) < Convert.ToInt32(current.data))
                return SearchTree(current.leftChild);
            else
                return SearchTree(current.rightChild);
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

        public void ChooseAction(Node node, int i)
        {
            string input; 
            Console.WriteLine("A basic Binary Search Tree has been created. Would you like to search the tree or add to it? Please enter 'search' or 'add' and then press enter.");
            input = Console.ReadLine();
            switch (input)
            {
                case "search":
                    SearchTree(node);
                    break;
                case "add":
                    Insert(i);
                    break;
                default:
                    Console.WriteLine("Sorry, that's not a valid choice. Press 'enter' to try again.");
                    Console.ReadLine();
                    ChooseAction(node, i);
                    break;
            }
        }
    }
}
