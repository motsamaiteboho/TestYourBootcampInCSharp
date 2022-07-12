namespace BootcampFunctions;
public class RegCheck
{
    public static bool Execute(string Reg, string Loc){
        return Reg.EndsWith(Loc);
    }
}