using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class CCHashMapTests
  {

    [Fact]
    public void CanHashAndReturnFalse()
    {
      DataStructures.HashMap people = new HashMap(48);

      Assert.False(people.Contains("Andres"));


      people.Set("Andres", "Brother");
      people.Set("Caroline", "Sister");
      people.Set("Esther", "Sister");
      people.Set("Bernie", "Brother");

      Assert.True(people.Contains("Andres"));
    }

    [Fact]
    public void CanGetAndHandleNull()
    {
      DataStructures.HashMap people = new HashMap(48);

      Assert.False(people.Contains("Andres"));


      people.Set("Andres", "Brother");
      people.Set("Caroline", "Sister");
      people.Set("Esther", "Sister");
      people.Set("Bernie", "Brother");

      Assert.Equal($"Bernie: Brother", people.Get("Bernie"));
      Assert.Equal($"Item: Benjamin, not found", people.Get("Benjamin"));
    }


  }
}
