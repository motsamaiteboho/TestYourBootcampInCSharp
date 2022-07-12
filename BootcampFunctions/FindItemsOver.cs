namespace  BootcampFunctions;
public class FindItemsOver
{
    public static List<Item>  Execute(List<Item>  itemList, int num)
    {
         List<Item> itemsOver = new List<Item>();
        for (var i = 0; i < itemList.Count(); i++)
        {
            var item = itemList[i];
            if (item.Qty > num)
            {
                itemsOver.Add(item);
            }
        }
        return itemsOver;
    }
}