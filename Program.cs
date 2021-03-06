using System;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);
            tree.root.left.left.left = new Node(12);
            tree.root.left.left.right = new Node(11);
         
            Console.WriteLine("Вывод дерева: ");
            tree.reverseLevelOrder(tree.root);
        }
    }
}