using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class TotalPhoneBillTest
{
    [Fact]
    public void ShouldReturnR745WhenCalledWithcallsmscallsmssms(){
        Assert.Equal("R7.45",TotalPhoneBill.Execute("call, sms, call, sms, sms"));
    }

    [Fact]
    public void ShouldReturnR340WhenCalledWithcallsms(){
        Assert.Equal("R3.40",TotalPhoneBill.Execute("call, sms"));
    }

    [Fact]
    public void ShouldReturnR130WhenCalledWithsmssms(){
        Assert.Equal("R1.30",TotalPhoneBill.Execute("sms, sms"));
    }
}