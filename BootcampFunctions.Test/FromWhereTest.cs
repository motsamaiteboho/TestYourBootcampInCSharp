using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class FromWhereTest
{
    [Fact]
    public void ShouldReturnBellvilleTownWhenCalledWithCY(){
        Assert.Equal("Bellville", FromWhere.Execute("CY"));
    }
     [Fact]
    public void ShouldReturnPaarlTownWhenCalledWithCJ(){
        Assert.Equal("Paarl", FromWhere.Execute("CJ"));
    }
     [Fact]
    public void ShouldReturnCapeTownWhenCalledWithCA(){
        Assert.Equal("Cape Town", FromWhere.Execute("CA"));
    }
    
}