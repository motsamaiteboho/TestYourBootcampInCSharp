using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class MostProfitableDepartmentTest
{
    [Fact]
    public void ShouldReturnHardwareForDataset1(){
        List<SalesData> salesData = new List<SalesData>();
        salesData.Add(new SalesData("hardware",4500,"Monday"));
        salesData.Add(new SalesData("outdoor",1500,"Monday"));
        salesData.Add(new SalesData("carpentry",5500,"Monday"));
        salesData.Add(new SalesData("hardware",7500,"Tuesday"));
        Assert.Equal("hardware",MostProfitableDepartment.Execute(salesData)); 
    }
    [Fact]
    public void ShouldReturnOutdoorForDataset2(){
        List<SalesData> salesData = new List<SalesData>();
        salesData.Add(new SalesData("hardware",4500,"Monday"));
        salesData.Add(new SalesData("outdoor",1500,"Monday"));
        salesData.Add(new SalesData("carpentry",5500,"Monday"));
        salesData.Add(new SalesData("hardware",500,"Tuesday"));
         salesData.Add(new SalesData("outdoor",8000,"Monday"));

        Assert.Equal("outdoor",MostProfitableDepartment.Execute(salesData)); 
    }
}