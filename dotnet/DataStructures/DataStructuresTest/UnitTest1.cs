using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class UnitTest1 : BinaryTree<int>
  {
    [Fact]
    public void BinaryTreeFindMaxTest()
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      //Asserts -2 returns if BinaryTree Node is null/empty
      Assert.Equal(-2147483648, findMax(tree.Root));

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

      //Asserts 50 is the highets value in the tree
      Assert.Equal(50, findMax(tree.Root));
    }

  }
}
