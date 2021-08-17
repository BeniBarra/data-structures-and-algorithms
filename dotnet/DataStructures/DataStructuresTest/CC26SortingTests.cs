using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class CC26SortingTests : CC26Sorting
  {
    [Fact]
    public void AEmptyArr()
    {
      int[] arr = { };

      Assert.Equal(arr, InsertionSort(arr));
    }

    [Fact]
    public void BSingleValueArr()
    {
      int[] arr = { 1 };

      Assert.Equal(arr, InsertionSort(arr));
    }

    [Fact]
    public void CProperReturn()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, InsertionSort(arr));
    }

    [Fact]
    public void DUnchangedArr()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, InsertionSort(arr));
    }
  }
}
