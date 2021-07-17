using System;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class UnitTest1
  {
    [Fact]
    public void ProofOfLife()
    {
      LinkedList list = new LinkedList();
      Assert.NotNull(list);
    }

    [Fact]
    public void ProofOfHeadAndNext()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.Equal(9, list.Head.Value);
      Assert.Equal(6, list.Head.Next.Value);
    }

    [Fact]
    public void ProofOfInsertAndList()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.True(list.Includes(6));
      Assert.False(list.Includes(12));
    }

    [Fact]
    public void ProofOflistAndPrint()
    {
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(6);
      list.Insert(9);
      Assert.Equal("(9) -> (6) -> (3) -> NULL", list.Print());
    }
  }
}
