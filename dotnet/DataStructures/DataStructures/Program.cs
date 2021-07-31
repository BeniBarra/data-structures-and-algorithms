using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      int[] numbers = new int[] { 9, 4, 17, 3, 6, 22, 5, 7, 20 };

      foreach (int num in numbers) { tree.Add(tree.Root, num); }
      List<int> nodeValues = new List<int>();
      nodeValues = LevelOrderTraversal(tree);

      string testNumbers = "";

      foreach (int value in nodeValues)
      {
        testNumbers += $"{value} ";
      }
      Console.WriteLine($"{testNumbers}");
    }









    public static List<int> PreOrderTraversal(Node<int> node, List<int> values)
    {
      values.Add(node.Value);

      if (node.Left != null) { PreOrderTraversal(node.Left, values); }
      if (node.Right != null) { PreOrderTraversal(node.Right, values); }
      return values;
    }

    public static List<int> InOrderTraversal(Node<int> node, List<int> values)
    {
      if (node.Left != null) { InOrderTraversal(node.Left, values); }

      values.Add(node.Value);

      if (node.Right != null) { InOrderTraversal(node.Right, values); }

      return values;
    }

    public static List<int> PostOrderTraversal(Node<int> node, List<int> values)
    {
      if (node.Left != null) { PostOrderTraversal(node.Left, values); }
      if (node.Right != null) { PostOrderTraversal(node.Right, values); }

      values.Add(node.Value);

      return values;
    }

    public static List<int> LevelOrderTraversal(BinarySearchTree<int> tree)
    {
      List<int> values = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

      while (nodes.Peek() != null)
      {
        Node<Node<int>> node = nodes.Dequeue();
        Node<int> currentNode = node.Value;

        values.Add(currentNode.Value);

        if (currentNode.Left != null) { nodes.Enqueue(currentNode.Left); }
        if (currentNode.Right != null) { nodes.Enqueue(currentNode.Right); }
      }
      return values;
    }

    public static bool Contains(Node<int> root, int target)
    {
      if (root != null)
      {
        if (root.Value == target)
        {
          return true;
        }
      }
      else if (root.Value > target)
      {
        return Contains(root.Left, target);
      }
      else if (root.Value < target)
      {
        return Contains(root.Right, target);
      }
      return false;
    }
  }
}
