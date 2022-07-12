namespace BootcampFunctions;

public class TotalPhoneBill
{
    public static string Execute(string lstBills)
    {
        string[] bill = lstBills.Split(",");
        double totalbill = 0;
        for (var i = 0; i < bill.Count(); i++)
        {
            var temp = bill[i].Trim();
            if (temp == "sms")
            {
                totalbill += 0.65;
            }
            else
              if (temp == "call")
            {
                totalbill += 2.75;
            }
        }
        return "R" + totalbill.ToString("#.00");
    }
}