using PseudoQueue.Classes;
using System;
using Xunit;

namespace PseudoQueueTest
{
    public class PseudoQTests
    {
        [Fact]
        public void EnqueueAndDequeueTest()
        {
      PseudoQueue<int> queue = new PseudoQueue<int>();
      queue.Enqueue(4);

      Assert.Equal(4, queue.Dequeue());
      Assert.Throws<NullReferenceException>(() => queue.Dequeue());
    }
    }
}
