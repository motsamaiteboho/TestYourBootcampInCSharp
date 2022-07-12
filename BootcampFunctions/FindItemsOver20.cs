namespace BootcampFunctions;
public class Item
{
    private string name = string.Empty;
    private int qty;
    public Item(string name,int qty){
        this.name =name;
        this.qty = qty;
    }
    public string Name 
    { 
        get{return name;}
        set{name = value;}
    }
    public int Qty 
    { 
        get{return qty;} 
        set{qty = value;}
    }
}

public class FindItemsOver20
{
    public static List<Item>  Execute(List<Item>  itemList)
    {
         List<Item> itemsOver20 = new List<Item>();
        for (var i = 0; i < itemList.Count(); i++)
        {
            var item = itemList[i];
            if (item.Qty > 20)
            {
                itemsOver20.Add(item);
            }
        }
        return itemsOver20;
    }
}