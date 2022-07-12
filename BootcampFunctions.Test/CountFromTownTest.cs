using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class CountFromTownTest
{
    [Fact]
    public void shouldReturn3WhenCalledWithStringCL124CY567CL345CJ456CL34TownNameCL(){
        Assert.Equal(3,CountFromTown.Execute("CL 124,CY 567,CL 345, CJ 456,CL 34","CL"));
    }
    [Fact]
    public void shouldReturn1WhenCalledWithStringCL124CY567CL345CJ456CL441TownNameCJ(){
        Assert.Equal(1, CountFromTown.Execute("CL 124,CY 567,CL 345, CJ 456,CL 341","CJ"));
    }
     [Fact]
    public void shouldReturn4WhenCalledWithStringCJ345123CK345CJ123CJ875CL891CJ218TownNameCJ(){
        Assert.Equal(4, CountFromTown.Execute("CJ 345 123,CK 345,CJ 123,CJ 875,CL 891,CJ 218","CJ"));
    }
}