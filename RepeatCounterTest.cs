
using Xunit;
using System;

namespace Counter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_CheckIfContains()
    {
      RepeatCounter countTest = new RepeatCounter();
      Assert.Equal(1, countTest.CountRepeats("duck", "duck"));
    }
  }
}
