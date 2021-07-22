using System;

namespace DataStructures
{
    public class Program : Zipper
    {
    public static void Main(string[] args)
    {
      LinkedList list1 = new LinkedList();
      list1.Insert(9);
      list1.Insert(7);
      list1.Insert(5);
      list1.Insert(3);
      list1.Insert(1);

      LinkedList list2 = new LinkedList();
      list2.Insert(8);
      list2.Insert(6);
      list2.Insert(4);
      list2.Insert(2);

      ZipLists(list1, list2);
    }
  }
}
