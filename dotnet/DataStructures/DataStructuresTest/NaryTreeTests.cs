using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class NaryTreeTests : NaryTree<int>
  {
    [Fact]
    public void WontFizzBuzzTest()
    {
      NaryTree<int> tree = new NaryTree<int>();

      Node<int> root = new(2);
      Node<int> c1A = new(3);
      Node<int> c1B = new(7);
      Node<int> c1C = new(5);
      root.Leaves.Add(c1A);
      root.Leaves.Add(c1B);
      root.Leaves.Add(c1C);

      Node<int> c2A = new(14);
      Node<int> c2B = new(10);
      Node<int> c2C = new(15);
      Node<int> c2D = new(30);
      c1B.Leaves.Add(c2A);
      c1B.Leaves.Add(c2B);
      c1B.Leaves.Add(c2C);
      c1B.Leaves.Add(c2D);

      tree.Root = root;

      NaryTree<string> results = FizzBuzz(tree);

      Assert.Equal("7", results.Root.Leaves[1].Value);
    }

    [Fact]
    public void WillFizzBuzzTest()
    {
      NaryTree<int> tree = new NaryTree<int>();

      Node<int> root = new(2);
      Node<int> c1A = new(3);
      Node<int> c1B = new(7);
      Node<int> c1C = new(5);
      root.Leaves.Add(c1A);
      root.Leaves.Add(c1B);
      root.Leaves.Add(c1C);

      Node<int> c2A = new(14);
      Node<int> c2B = new(10);
      Node<int> c2C = new(15);
      Node<int> c2D = new(30);
      c1B.Leaves.Add(c2A);
      c1B.Leaves.Add(c2B);
      c1B.Leaves.Add(c2C);
      c1B.Leaves.Add(c2D);

      tree.Root = root;

      NaryTree<string> results = FizzBuzz(tree);

      Assert.Equal("Fizz", results.Root.Leaves[0].Value);
      Assert.Equal("Buzz", results.Root.Leaves[2].Value);
      Assert.Equal("Buzz", results.Root.Leaves[1].Leaves[1].Value);
      Assert.Equal("FizzBuzz", results.Root.Leaves[1].Leaves[2].Value);
      Assert.Equal("FizzBuzz", results.Root.Leaves[1].Leaves[3].Value);
    }

    [Fact]
    public void FizzBuzzNullTest()
    {
      NaryTree<int> tree = new();

      NaryTree<string> results = FizzBuzz(tree);

      Assert.Null(results.Root);
    }
  }
}
