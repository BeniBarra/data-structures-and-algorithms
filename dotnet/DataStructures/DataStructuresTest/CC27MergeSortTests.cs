using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class CC27MergeSortTests : MergeAndSort
  {
    [Fact]
    public void EmptyArrTest()
    {
      int[] arr = { };

      Assert.Equal(arr, MergeSort(arr));
    }

    [Fact]
    public void SingleValueArrTest()
    {
      int[] arr = { 1 };

      Assert.Equal(arr, MergeSort(arr));
    }

    [Fact]
    public void ProperReturnTest()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, MergeSort(arr));
    }

    [Fact]
    public void UnchangedArrTest()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, MergeSort(arr));
    }
  }
}
