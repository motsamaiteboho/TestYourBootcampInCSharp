using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class IsFromBellvilleTest
{
    [Fact]
    public void ShouldReturnTrueWhenCalledWithCY123(){
        Assert.Equal(true, IsFromBellville.Execute("CY 123"));
    }

    [Fact]
    public void ShouldReturnFalseWhenCalledWithCJ123(){
        Assert.Equal(false, IsFromBellville.Execute("CJ 123"));
    }

    [Fact]
    public void ShouldReturnTrueWhenCalledWithCY783(){
        Assert.Equal(true, IsFromBellville.Execute("CY 783"));
    }
}