using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program : NaryTree<int>
  {
    public static void Main(string[] args)
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

      FizzBuzz(tree);
    }
  }
}
