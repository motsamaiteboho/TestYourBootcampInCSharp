using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class IsWeekdayTest
{
    [Fact]
    public void ShouldReturnFalseWhenCalledWithSaturday(){
        Assert.Equal(false,IsWeekday.Execute("Saturday"));
    }

    [Fact]
    public void ShouldReturnTrueWhenCalledWithModay(){
        Assert.Equal(true, IsWeekday.Execute("Monday"));
    }

    [Fact]
    public void ShouldReturnFalseWhenCalledWithSunday(){
        Assert.Equal(false, IsWeekday.Execute("Sunday"));
    }
}