namespace BootcampFunctions;

public class CountFromTown
{
    public static int Execute(string Regs, string loc){
        return Regs.Split(",").Count(reg => reg.Trim().StartsWith(loc));
    }
}