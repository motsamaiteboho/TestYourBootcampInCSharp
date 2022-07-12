using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class YearsAgoTest
{
    [Fact]
    public void ShouldReturn46WhenCalledWith1976(){
        Assert.Equal(76,YearsAgo.Execute(1946));
    }
    [Fact]
    public void ShouldReturn22WhenCalledWith2000(){
        Assert.Equal(22,YearsAgo.Execute(2000));
    }
    [Fact]
    public void ShouldReturn25WhenCalledWith1997(){
        Assert.Equal(25,YearsAgo.Execute(1997));
    }
}