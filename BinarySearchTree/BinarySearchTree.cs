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

        public void SearchTree(Node node, int i)
        {
            Console.WriteLine("Please enter a number you'd like to search for, and then press 'enter'.");
            int searchNode = int.Parse(Console.ReadLine());
            Node current = root;
            string wantToAdd;
            string searchAgain;

            if (root == null)
            {
                Console.WriteLine(searchNode + " not found. Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else
                {
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (searchNode == root.leftChild.data)
            {
                Console.WriteLine(root.leftChild.data + " is in the tree! Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else
                { 
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            if (searchNode == root.rightChild.data)
            {
                Console.WriteLine(root.rightChild.data + " is in the tree!Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else
                { 
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            if (searchNode == root.leftChild.leftChild.data)
            {
                Console.WriteLine(root.leftChild.leftChild.data + " is in the tree!Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else 
                {
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            if (searchNode == root.leftChild.rightChild.data)
            {
                Console.WriteLine(root.leftChild.rightChild.data + " is in the tree!Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else 
                {
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (searchNode == root.rightChild.rightChild.data)
            {
                Console.WriteLine(root.rightChild.rightChild.data + " is in the tree!Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else 
                {
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (searchNode == root.rightChild.leftChild.data)
            {
                Console.WriteLine(root.rightChild.leftChild.data + " is in the tree!Would you like to search for another value? Type 'yes' or 'no', and then press 'enter'.");
                searchAgain = Console.ReadLine();
                if (searchAgain == "yes")
                {
                    SearchTree(node, i);
                }
                else
                {
                    Console.WriteLine("Thanks for using the Binary Search Tree!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            { 
                Console.WriteLine(searchNode + " is not in the tree. Would you like to add it? Type 'yes' or 'no' and then press 'Enter'.");
                wantToAdd = Console.ReadLine();

                if (wantToAdd == "yes")
                    {
                        InsertNode(i);
                    }
                else
                    { 
                        Console.WriteLine("Thanks for using the Binary Search Tree!");
                        Console.ReadLine();
                        Console.Clear();
                    }
            }

        }
        public void InsertNode(int i)
        {
            Console.WriteLine("Please enter a number you'd like to insert, and then press 'enter'.");
            int nodeToAdd = int.Parse(Console.ReadLine());

            Node newNode = new Node(i);
            newNode.data = i;

            if (root == null)
            {
                root = newNode;
            }
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
                    SearchTree(node, i);
                    break;
                case "add":
                    InsertNode(i);
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
