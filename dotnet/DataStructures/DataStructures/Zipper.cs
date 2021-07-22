using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Zipper
  {
    public static string ZipLists(LinkedList list1, LinkedList list2)
    {
      Node current1 = list1.Head;
      Node current2 = list2.Head;

      if (current1 == null || current2 == null)
      {
        throw new Exception("Sorry something was wrong with the lists provided");
      }
      while (current1 != null && current2 != null)
      {
        // Store list1 next Node
        Node storedNext = current1.Next;
        // Point current list1 next to list 2
        current1.Next = current2;
        // move current2 forward to next position
        current2 = current2.Next;
        // move current1 forward to next position
        current1 = current1.Next;
        // Point current list1 next to stored list1 Node
        current1.Next = storedNext;
        // move current1 forward to stored position
        current1 = current1.Next;
        // loop continues until reaching the end of both lists
      }
      return list1.Print();
    }
  }
}
