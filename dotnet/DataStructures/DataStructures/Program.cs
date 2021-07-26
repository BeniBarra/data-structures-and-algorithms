using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args)
    {
      StackIterative();
      //StackRecursive();
    }

    private static void StackIterative()
    {
      Stack<string> myFamily = new Stack<string>();
      myFamily.Push("Andres");
      myFamily.Push("Bernie");
      myFamily.Push("Caro");
      myFamily.Push("Esther");

      string returnStr = "";

      while (myFamily.Peek())
      {
        returnStr = myFamily.Pop();
        Console.WriteLine(returnStr);
      }

      //foreach (Node<string> person in myFamily)
      //{
      //  Console.WriteLine(person.Value);
      //}
    }

    static void StackRecursive()
    {
      Stack<string> myFamily = new Stack<string>();
      myFamily.Push("Andres");
      myFamily.Push("Bernie");
      myFamily.Push("Caro");
      myFamily.Push("Esther");
      IterateStackRecursively(myFamily);
    }

    static void IterateStackRecursively(Stack<string> stack)
    {
      if (stack.Peek()) { return; }

      string person = stack.Pop();
      Console.WriteLine(person);

      IterateStackRecursively(stack);
    }

    static void QueueIterative()
    {
      Queue<string> myFamily = new Queue<string>();
      myFamily.Enqueue("Andres");
      myFamily.Enqueue("Bernie");
      myFamily.Enqueue("Caro");
      myFamily.Enqueue("Esther");

      while (myFamily.Peek() == myFamily.Front.Value)
      {
        Node<string> person = myFamily.Dequeue();
        Console.WriteLine(person.Value);
      }
    }

    static void QueueRecursively()
    {
      Queue<string> myFamily = new Queue<string>();
      myFamily.Enqueue("Andres");
      myFamily.Enqueue("Bernie");
      myFamily.Enqueue("Caro");
      myFamily.Enqueue("Esther");

      IterateQueueRecursively(myFamily);
    }

    private static void IterateQueueRecursively(Queue<string> queue)
    {
      if (queue.Peek() != queue.Front.Value) { return; }
      {
        Node<string> person = queue.Dequeue();
        Console.WriteLine(person.Value);

        IterateQueueRecursively(queue);
      }
    }

  }
}
