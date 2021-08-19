using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class CC28QuickSortTests : CC28QuickSort
  {

    [Fact]
    public void AEmptyArr()
    {
      int[] arr = { };
      int[] bar = { };
      QuickSort(arr, 0, 0);
      Assert.Equal(arr, bar);
    }

    [Fact]
    public void BSingleValueArr()
    {
      int[] arr = { 1 };
      int[] bar = { 1 };
      QuickSort(arr, 0, 0);

      Assert.Equal(arr, bar);
    }

    [Fact]
    public void CProperReturn()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };
      QuickSort(arr, 0, 3);

      Assert.Equal(bar, arr);
    }

    [Fact]
    public void DUnchangedArr()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };
      QuickSort(arr, 0, 3);

      Assert.Equal(bar, arr);
    }

  }
}
