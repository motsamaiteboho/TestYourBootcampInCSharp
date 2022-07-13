using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class RegCheckTest
{
    [Fact]
    public void ShouldReturnTrueWhenCalledWithDC55YUGPAlongWithGP(){
        Assert.Equal (true,RegCheck.Execute("DC 55 YU GP","GP") );
    }

    [Fact]
    public void ShouldReturnFalseWhenCalledWithDC55YUGPAlongWithEC(){
        Assert.Equal(false,RegCheck.Execute("DC 55 YU GP","EC"));
    }

    [Fact]
    public void ShouldReturnTrueWhenCalledWith5566LAlongWithL(){
        Assert.Equal(true,RegCheck.Execute("5566 L","L"));
    }
}