using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class IsFromBellvilleTest
{
    [Fact]
    public void ShouldReturnTrueWhenCalledWithCY123(){
        Assert.True(IsFromBellville.Execute("CY 123"));
    }

    [Fact]
    public void ShouldReturnFalseWhenCalledWithCJ123(){
        Assert.False( IsFromBellville.Execute("CJ 123"));
    }

    [Fact]
    public void ShouldReturnTrueWhenCalledWithCY783(){
        Assert.True(IsFromBellville.Execute("CY 783"));
    }
}