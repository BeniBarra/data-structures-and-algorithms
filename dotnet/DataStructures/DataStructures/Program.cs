using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program : NaryTree<int>
  {
    public static void Main(string[] args)
    {
      GraphCoolness();
    }

    static void GraphCoolness()
    {
      Graph<string> graph = new Graph<string>();

      var aNode = graph.AddNode("A");
      var bNode = graph.AddNode("B");
      var cNode = graph.AddNode("C");
      var dNode = graph.AddNode("D");
      var eNode = graph.AddNode("E");

      graph.AddEdge(aNode, bNode, 2);
      graph.AddEdge(aNode, cNode, 4);
      graph.AddEdge(bNode, cNode, 5);
      graph.AddEdge(dNode, eNode, 8);
      graph.AddEdge(aNode, eNode, 3);

      graph.GetNodes();
    }

    public static void RunFizzBuzz()
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
