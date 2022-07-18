using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class IsWeekdayTest
{
    [Fact]
    public void ShouldReturnFalseWhenCalledWithSaturday(){
        Assert.False(IsWeekday.Execute("Saturday"));
    }

    [Fact]
    public void ShouldReturnTrueWhenCalledWithModay(){
        Assert.True(IsWeekday.Execute("Monday"));
    }

    [Fact]
    public void ShouldReturnFalseWhenCalledWithSunday(){
        Assert.False(IsWeekday.Execute("Sunday"));
    }
}