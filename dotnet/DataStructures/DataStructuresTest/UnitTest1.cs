using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class UnitTest1
  {
    [Fact]
    public void ProofOfPreOrderAndAdd()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      int[] numbers = new int[] { 9, 4, 17, 3, 6, 22, 5, 7, 20 };

      foreach (int num in numbers) { tree.Add(tree.Root, num); }
      List<int> nodeValues = new List<int>();
      nodeValues = PreOrderTraversal(tree.Root, new List<int>());

      string testNumbers = "";

      foreach (int value in nodeValues)
      {
        testNumbers += $"{value} ";
      }
      Assert.Equal("9 4 3 6 5 7 17 22 20 ", testNumbers);
    }

    [Fact]
    public void ProofOfInOrderAndAdd()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      int[] numbers = new int[] { 9, 4, 17, 3, 6, 22, 5, 7, 20 };

      foreach (int num in numbers) { tree.Add(tree.Root, num); }
      List<int> nodeValues = new List<int>();
      nodeValues = InOrderTraversal(tree.Root, new List<int>());

      string testNumbers = "";

      foreach (int value in nodeValues)
      {
        testNumbers += $"{value} ";
      }
      Assert.Equal("3 4 5 6 7 9 17 20 22 ", testNumbers);
    }

    [Fact]
    public void ProofOfPostOrderAndAdd()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      int[] numbers = new int[] { 9, 4, 17, 3, 6, 22, 5, 7, 20 };

      foreach (int num in numbers) { tree.Add(tree.Root, num); }
      List<int> nodeValues = new List<int>();
      nodeValues = PostOrderTraversal(tree.Root, new List<int>());

      string testNumbers = "";

      foreach (int value in nodeValues)
      {
        testNumbers += $"{value} ";
      }
      Assert.Equal("3 5 7 6 4 20 22 17 9 ", testNumbers);
    }




    //------------------------------------------------------------------------------------------//




    public List<int> PreOrderTraversal(Node<int> node, List<int> values)
    {
      values.Add(node.Value);

      if (node.Left != null) { PreOrderTraversal(node.Left, values); }
      if (node.Right != null) { PreOrderTraversal(node.Right, values); }
      return values;
    }

    public List<int> InOrderTraversal(Node<int> node, List<int> values)
    {
      if (node.Left != null) { InOrderTraversal(node.Left, values); }

      values.Add(node.Value);

      if (node.Right != null) { InOrderTraversal(node.Right, values); }

      return values;
    }

    public List<int> PostOrderTraversal(Node<int> node, List<int> values)
    {
      if (node.Left != null) { PostOrderTraversal(node.Left, values); }
      if (node.Right != null) { PostOrderTraversal(node.Right, values); }

      values.Add(node.Value);

      return values;
    }

    public List<int> LevelOrderTraversal(BinarySearchTree<int> tree)
    {
      List<int> values = new List<int>();
      DataStructures.Queue<Node<int>> nodes = new DataStructures.Queue<Node<int>>();

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

    public bool Contains(Node<int> root, int target)
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
