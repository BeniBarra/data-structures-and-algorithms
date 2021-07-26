using System;
using Xunit;
using DataStructures;

namespace StackTests
{
  public class StackTests
  {
    [Fact]
    public void PushStacksTest()
    {
      //Assert push
      Stack<string> myFamily = new();
      myFamily.Push("Andres");
      myFamily.Push("Bernie");
      myFamily.Push("Caro");
      myFamily.Push("Esther");

      Assert.Equal("Esther", myFamily.Top.Value);
      Assert.Equal("Bernie", myFamily.Top.Next.Next.Value);
    }
    [Fact]
    public void PopStacksTest()
    {
      //Assert EmptyStack and catch throw
      Stack<string> myFamily = new();
      myFamily.Push("Andres");
      myFamily.Push("Bernie");
      myFamily.Push("Caro");
      myFamily.Push("Esther");

      while (myFamily.Peek())
      {
        myFamily.Pop();
      }
      //Assert.Throws<Exception>(() => myFamily.Pop());
      Assert.True(myFamily.EmptyStack());
    }
    [Fact]
    public void StackPeekTest()
    {
      //Assert an empty stack & Assert Peek
      Stack<string> myFamily = new();

      Assert.True(myFamily.EmptyStack());

      Assert.Throws<Exception>(() => myFamily.Peek());
      myFamily.Push("Andres");
      myFamily.Push("Bernie");
      myFamily.Push("Caro");
      myFamily.Push("Esther");

      Assert.True(myFamily.Peek());

    }
  }
}
