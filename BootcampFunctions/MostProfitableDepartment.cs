namespace BootcampFunctions;
public class SalesData
{
    private string department = string.Empty;
    private int sales;

    private string day = string.Empty;
    public SalesData(string department,int sales,string day){
        this.department = department;
        this.sales = sales;
        this.day = day;
    }
    public string Department
    { 
        get{return department;}
        set{department = value;}
    }
    public int Sales 
    { 
        get{return sales;} 
        set{sales = value;}
    }

    public string Day
    { 
        get{return day;}
        set{day = value;}
    }
}
public class MostProfitableDepartment
{
    public static string Execute(List<SalesData> salesData)
    {

        Dictionary<String,int> salesMap = new Dictionary<string, int>();
    
        foreach(var sale in salesData)
        {
            salesMap[sale.Department] = 0;
        }

        foreach(var sale in salesData)
        {
            var currentdepartmentotal = salesMap[sale.Department];
            currentdepartmentotal += sale.Sales;
            salesMap[sale.Department] = currentdepartmentotal;
        }
        var currentMaxSales = 0;
        var currentDepartment = "";
        foreach (var saleDepartment in salesMap){
            var currentDepartmentSales = salesMap[saleDepartment.Key];
            if (currentDepartmentSales > currentMaxSales){
                currentMaxSales = currentDepartmentSales;
                currentDepartment = saleDepartment.Key;
            }
        }
        return currentDepartment;
    }
}