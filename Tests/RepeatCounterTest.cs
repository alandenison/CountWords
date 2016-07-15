
using Xunit;
using System;

namespace Counter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_CheckIfContains()
    {
      int methodResult = 1;
      RepeatCounter testCounter = new RepeatCounter("duck", "duck");
      int result = testCounter.CountRepeats();
      Assert.Equal(methodResult, result);
    }
    [Fact]
    public void CountRepeats_CheckHowManyInstancesAreInString()
    {
      int methodResult = 2;
      RepeatCounter testCounter = new RepeatCounter("duck duck goose", "duck");
      int result = testCounter.CountRepeats();
      Assert.Equal(methodResult, result);
    }
    [Fact]
    public void CountRepeats_IgnoreCaseWHenSearching()
    {
      int methodResult = 1;
      RepeatCounter testCounter = new RepeatCounter("duck", "Duck");
      int result = testCounter.CountRepeats();
      Assert.Equal(methodResult, result);
    }
  }
}
