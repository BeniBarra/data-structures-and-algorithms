using PseudoQueue.Classes;
using System;

namespace PseudoQueue
{
  class Program
  {
    static void Main(string[] args)
    {
      PseudoQueue<int> queue = new PseudoQueue<int>();
      queue.Enqueue(4);
      queue.Enqueue(3);
      queue.Enqueue(2);
      queue.Enqueue(1);

      queue.Dequeue();
    }
  }
}
