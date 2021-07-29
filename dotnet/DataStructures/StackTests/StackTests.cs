using System;
using Xunit;
using DataStructures;

namespace StackTests
{
  public class StackTests
  {
    [Fact]
    public void ReturnsValidBracket()
    {
      string str = "{[()]}";
      Assert.True(ValidBrackets(str));
    }

    [Fact]
    void ReturnsInvalidBracket()
    {
      string str = "{[}]";
      Assert.False(ValidBrackets(str));
    }

    public static bool ValidBrackets(string str)
    {
      char temp;
      Stack<char> stack = new Stack<char>();
      foreach (char c in str)
      {
        if (c == '{' || c == '[' || c == '(')
        {
          stack.Push(c);
          temp = stack.Peek();
          Console.WriteLine($"{temp} was push to stack");
        }
        else if (c == '}')
        {
          temp = stack.Peek();
          if (temp == '{')
          {
            stack.Pop();
          }
          else
          {
            Console.WriteLine("Invalid } Bracket");
            return false;
          }
        }

        else if (c == ']')
        {
          temp = stack.Peek();
          if (temp == '[')
          {
            stack.Pop();
          }
          else
          {
            Console.WriteLine("Invalid ] Bracket");
            return false;
          }
        }

        else if (c == ')')
        {
          temp = stack.Peek();
          if (temp == '(')
          {
            stack.Pop();
          }
          else
          {
            Console.WriteLine("Invalid ) Bracket");
            return false;
          }
        }
      }

      if (stack.IsEmpty() == true)
      {
        Console.WriteLine("All Brackets Valid");
        return true;
      }
      else
      {
        Console.WriteLine("You made it to the end");
        return false;
      }
    }
  }
}

