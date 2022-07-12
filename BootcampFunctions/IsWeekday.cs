namespace BootcampFunctions;

public class IsWeekday{
    public static bool Execute(string sday){
        string[] weekdays = {"Monday","Tuesday","Wednesday","Thursday","Friday"};
        return weekdays.Contains(sday);
    }
}