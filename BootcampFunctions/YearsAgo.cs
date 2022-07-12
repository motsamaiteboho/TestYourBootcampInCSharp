namespace BootcampFunctions;

public class YearsAgo
{
    public static int Execute(int years){
        DateTime date = DateTime.Now;
        return date.Year - years;
    }
}