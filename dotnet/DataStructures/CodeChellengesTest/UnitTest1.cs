using stack_queue_animal_shelter;
using System;
using Xunit;

namespace CodeChellengesTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
      [Fact]
      void AddAndTakeFromQueue()
      {
        Shelter shelter = new();

        shelter.AddAnimal("cooper", "dog");

        Assert.Equal("cooper", shelter.TakeAnimal("dog"));
      }
    }
    }
}
