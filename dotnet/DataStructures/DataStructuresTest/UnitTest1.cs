using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class UnitTest1<T>
  {
    [Fact]
    public void ProofOfLife()
    {
      DataStructures.LinkedList<T> list = new DataStructures.LinkedList<T>();
      Assert.NotNull(list);
    }

    [Fact]
    public void ProofOfHeadAndNext()
    {
      DataStructures.LinkedList<int> list = new DataStructures.LinkedList<int>();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.Equal(9, list.Head.Value);
      Assert.Equal(6, list.Head.Next.Value);
    }

    //[Fact]
    //public void ProofOfInsertAndList()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  Assert.True(list.Includes(6));
    //  Assert.False(list.Includes(12));
    //}

    //[Fact]
    //public void ProofOflistAndPrint()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  Assert.Equal("(9) -> (6) -> (3) -> NULL", list.Print());
    //}

    //[Fact]
    //public void ProofOfAppend()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Append(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  Assert.Equal("(9) -> (6) -> (3) -> NULL", list.Print());
    //}



    //[Fact]
    //public void ProofOfInsertBefore()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  // Test's inserting at middle of list
    //  list.InsertBefore(6, 12);
    //  // Test's inserting at Head of list
    //  list.InsertBefore(9, 15);
    //  Assert.Equal("(15) -> (9) -> (12) -> (6) -> (3) -> NULL", list.Print());
    //}

    //[Fact]
    //public void ProofOfInsertAfter()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  // Test's inserting at middle of list
    //  list.InsertBefore(6, 12);
    //  // Test's inserting at Head of list
    //  Assert.Equal("(9) -> (12) -> (6) -> (3) -> NULL", list.Print());
    //}

    //[Fact]
    //public void ProofOfkth()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  list.Insert(12);
    //  list.Insert(15);
    //  list.Insert(18);
    //  Assert.Equal(12, list.kthFromEnd(4));
    //}

    //[Fact]
    //public void ProofOfkthOutOfRange()
    //{
    //  LinkedList list = new LinkedList();
    //  list.Insert(3);
    //  list.Insert(6);
    //  list.Insert(9);
    //  list.Insert(12);
    //  list.Insert(15);
    //  list.Insert(18);
    //  Assert.Equal(-1, list.kthFromEnd(10));
    //}

    //[Fact]
    //public void ProofOfkthNoList()
    //{
    //  LinkedList list = new LinkedList();
    //  Assert.Equal(-2, list.kthFromEnd(10));
    //}

    //[Fact]
    //public void ZipperTests()
    //{
    //  LinkedList list1 = new LinkedList();
    //  list1.Insert(9);
    //  list1.Insert(7);
    //  list1.Insert(5);
    //  list1.Insert(3);
    //  list1.Insert(1);

    //  LinkedList list2 = new LinkedList();
    //  list2.Insert(8);
    //  list2.Insert(6);
    //  list2.Insert(4);
    //  list2.Insert(2);

    //  Assert.Equal(
    //    "(1) -> (2) -> (3) -> (4) -> (5) -> (6) -> (7) -> (8) -> (9) -> NULL",
    //    ZipLists(list1, list2)
    //    );
    //}
  }
}
