using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class CountAllPaarlTest
{
    [Fact]
    public void shouldReturn3WhenCalledWithStringCJ345123CJ2345CL123546CK345CJ123(){
        Assert.Equal(3,CountAllPaarl.Execute("CJ 345 123,CJ 2345,CL 123-546,CK 345,CJ 123"));
    }
    [Fact]
    public void shouldReturn2WhenCalledWithStringCJ345123CK345CJ123(){
        Assert.Equal(2, CountAllPaarl.Execute("CJ 345 123,CK 345,CJ 123"));
    }
     [Fact]
    public void shouldReturn4WhenCalledWithStringCJ345123CK345CJ123CJ875CL891CJ218(){
        Assert.Equal(4, CountAllPaarl.Execute("CJ 345 123,CK 345,CJ 123,CJ 875,CL 891,CJ 218"));
    }
}