using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program : BinaryTree<int>
  {
    public static void Main(string[] args)
    {
      BinaryTree<int> tree = new BinaryTree<int>();


      Node<int> One = new Node<int>(2);
      Node<int> Two = new Node<int>(6);
      Node<int> Three = new Node<int>(5);
      Node<int> Four = new Node<int>(8);
      Node<int> Five = new Node<int>(20);
      Node<int> Six = new Node<int>(50);
      Node<int> Seven = new Node<int>(0);

      tree.Root = One;
      One.Left = Two;
      One.Right = Three;
      Two.Left = Seven;
      Two.Right = Six;
      Three.Left = Five;
      Three.Right = Four;

      findMax(tree.Root);
    }

    public static int findMax(Node<int> node)
    {
      if (node == null)
      {
        return int.MinValue;
      }

      int max = node.Value;
      int lMax = findMax(node.Left);
      int rMax = findMax(node.Right);

      if (lMax > max)
      {
        max = lMax;
      }
      if (rMax > max)
      {
        max = rMax;
      }
      Console.WriteLine($"{max}");
      return max;
    }
  }
}
