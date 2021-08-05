using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class NaryTree<T>
  {
    public Node<T> Root { get; set; }

    public static NaryTree<string> FizzBuzz(NaryTree<int> oldTree)
    {
      NaryTree<string> result = new();
      if (oldTree.Root != null)
      {
        result.Root = NodeBuzz(oldTree.Root);
        result.Root.Leaves = NodeMap(oldTree.Root.Leaves);
      }

      return result;
    }

    private static List<Node<string>> NodeMap(List<Node<int>> oldleaves)
    {
      List<Node<string>> newLeaves = new List<Node<string>>();

      foreach(Node<int> leaf in oldleaves)
      {
        Node<string> newLeaf = NodeBuzz(leaf);
        newLeaf.Leaves = NodeMap(leaf.Leaves);
        newLeaves.Add(newLeaf);
      }
      return newLeaves;
    }

    private static Node<string> NodeBuzz(Node<int> root)
    {
      int value = root.Value;
      Node<string> result = new("");

      if (value % 3 == 0 && value % 5 == 0) {result.Value = "FizzBuzz";}

      else if (value % 3 == 0) { result.Value = "Fizz"; }

      else if (value % 5 == 0) { result.Value = "Buzz"; }

      else { result.Value = $"{value}"; }

      return result;
    }
  }
}
