using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class CC31FindFirstRepeatingTests
  {

    [Fact]
    public void CanFindRepeatTest()
    {
      string testString = "Once upon a time, there was a brave princess who...";

      Assert.Equal("a", HashMap.FindRepeats(testString));
    }

    [Fact]
    public void CanFindNullTest()
    {
      string testString = "Each word in this sentence is a different string";

      Assert.Equal("There are no repeats in this sentence", HashMap.FindRepeats(testString));
    }


  }
}
