using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;

public class FindItemsOverTest
{
    [Fact]
    public void ShouldReturnResultsWhenCalledWithItemListOFProducts (){
        List<Item> itemList = new List<Item>();
        itemList.Add(new Item("pears",37));
        itemList.Add(new Item("bananas",27));
        itemList.Add(new Item("apples",10));
        itemList.Add(new Item("apples",3));

        List<Item> results = new List<Item>();
        itemList.Add(new Item("pears",37));
        itemList.Add(new Item("bananas",27));

        Assert.Equal(results.ToString(), FindItemsOver.Execute(itemList,20).ToString());
    }

    [Fact]
    public void ShouldReturnResults1WhenCalledWithItemList1OFProducts (){
        List<Item> itemList1 = new List<Item>();
        itemList1.Add(new Item("apples",10));
        itemList1.Add(new Item("apples",3));

        List<Item> results1 = new List<Item>();

        Assert.Equal(results1, FindItemsOver.Execute(itemList1,20));
    }
    [Fact]
    public void ShouldReturnResults2WhenCalledWithItemList2OFProducts (){
        List<Item> itemList2 = new List<Item>();
        itemList2.Add(new Item("apples",10));
        itemList2.Add(new Item("apples",3));
        itemList2.Add(new Item("bananas",27));

        List<Item> results2 = new List<Item>();
        results2.Add(new Item("bananas",27));

        Assert.Equal(results2.ToString(), FindItemsOver.Execute(itemList2,20).ToString());
    }
}