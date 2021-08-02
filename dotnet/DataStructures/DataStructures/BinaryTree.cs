using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public List<int> PreOrderTraversal(Node<int> node, List<int> values)
    {
      values.Add(node.Value);

      if (node.Left != null) {PreOrderTraversal(node.Left, values); }
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
      if(node.Left != null) { PostOrderTraversal(node.Left, values); }
      if (node.Right != null) { PostOrderTraversal(node.Right, values); }

      values.Add(node.Value);

      return values;
    }

    public List<int> LevelOrderTraversal(BinarySearchTree<int> tree)
    {
      List<int> values = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

      while(nodes.Peek() != null)
      {
        Node<Node<int>> node = nodes.Dequeue();
        Node<int> currentNode = node.Value;

        values.Add(currentNode.Value);

        if( currentNode.Left != null) { nodes.Enqueue(currentNode.Left); }
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

    public static int findMax(Node<int> node)
    {
      if (node == null)
      {
        return int.MinValue;
      }

      int res = node.Value;
      int lRes = findMax(node.Left);
      int rRes = findMax(node.Right);

      if(lRes > res)
      {
        res = lRes;
      }
      if (rRes > res)
      {
        res = rRes;
      }
      return res;
    }
  }
}
