using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class TransportFeeTest{
    [Fact]
    public void ShouldReturnR20FeeForMorningShift(){
        Assert.Equal("R20", TransportFee.Execute("morning"));
    }

    [Fact]
    public void ShouldReturnR10FeeForAfternoonShift(){
        Assert.Equal("R10", TransportFee.Execute("afternoon"));
    }
    [Fact]
    public void ShouldReturnFreeForMorningShift(){
        Assert.Equal("free", TransportFee.Execute("nightshift"));
    }
}