namespace BootcampFunctions;

public class CountAllPaarl
{
    public static int Execute(string Regs){
        return Regs.Split(",").Count(reg => reg.Trim().StartsWith("CJ"));
    }
}