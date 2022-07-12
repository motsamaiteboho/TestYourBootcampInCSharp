using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class GreetTest
{
    [Fact]
    public void ShouldBeAbleToGreetJo()
    {            
        Assert.Equal("Hello, Jo", Greet.Execute("Jo"));
    }

    [Fact]
    public void ShouldBeAbleToGreetLihle()
    {
        Assert.Equal("Hello, Lihle", Greet.Execute("Lihle"));
    }
}