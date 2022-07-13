using System;
using Xunit;
using BootcampFunctions;
namespace BootcampFunctions.Test;
using Newtonsoft.Json;
public class FindItemsOver20Test
{
    [Fact]
    public void ShouldReturnResultsWhenCalledWithItemListOFProducts (){
        List<Item> itemList = new List<Item>();
        itemList.Add(new Item("pears",37));
        itemList.Add(new Item("bananas",27));
        itemList.Add(new Item("apples",10));
        itemList.Add(new Item("apples",3));

        List<Item> results = new List<Item>();
        results.Add(new Item("pears",37));
        results.Add(new Item("bananas",27));

        var itemListJson = JsonConvert.SerializeObject(FindItemsOver20.Execute(itemList));
        var resultsJson = JsonConvert.SerializeObject(results);

        Assert.Equal(resultsJson,itemListJson);
    }

    [Fact]
    public void ShouldReturnResults1WhenCalledWithItemList1OFProducts (){
        List<Item> itemList1 = new List<Item>();
        itemList1.Add(new Item("apples",10));
        itemList1.Add(new Item("apples",3));

        List<Item> results1 = new List<Item>();

        Assert.Equal(JsonConvert.SerializeObject(results1),JsonConvert.SerializeObject(FindItemsOver20.Execute(itemList1)));
    }
    [Fact]
    public void ShouldReturnResults2WhenCalledWithItemList2OFProducts (){
        List<Item> itemList2 = new List<Item>();
        itemList2.Add(new Item("apples",10));
        itemList2.Add(new Item("apples",3));
        itemList2.Add(new Item("bananas",27));

        List<Item> results2 = new List<Item>();
        results2.Add(new Item("bananas",27));

        Assert.Equal(JsonConvert.SerializeObject(results2),JsonConvert.SerializeObject(FindItemsOver20.Execute(itemList2)));
    }
}