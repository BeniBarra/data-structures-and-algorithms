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
      Node<int> Two = new Node<int>(7);
      Node<int> Three = new Node<int>(5);
      Node<int> Four = new Node<int>(2);
      Node<int> Five = new Node<int>(6);
      Node<int> Six = new Node<int>(9);
      Node<int> Seven = new Node<int>(5);
      Node<int> Eight = new Node<int>(11);
      Node<int> Nine = new Node<int>(4);

      tree.Root = One;
      One.Left = Two;
      One.Right = Three;
      Two.Left = Four;
      Two.Right = Five;
      Three.Right = Six;
      Five.Left = Seven;
      Five.Right = Eight;
      Six.Left = Nine;

      string numList = LevelOrderTraversal(tree);

      
      Console.WriteLine($"{numList}");
    }

  }
}
