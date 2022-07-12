using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class CountRegNumberTest
{
    [Fact]
    public void shouldReturn3WhenCalledWithStringCA182736CY523519CJ812328(){
        Assert.Equal(3, CountRegNumber.Execute("CA 182736,CY 523519,CJ 812328"));
    }
    [Fact]
    public void shouldReturn1WhenCalledWithStringCA182736(){
        Assert.Equal(1, CountRegNumber.Execute("CA 182736"));
    }
     [Fact]
    public void shouldReturn3WhenCalledWithStringCL7896215CY562874(){
        Assert.Equal(5, CountRegNumber.Execute("CA 182736,CY 523519,CJ 812328,CL 7896215,CY 562874"));
    }
}