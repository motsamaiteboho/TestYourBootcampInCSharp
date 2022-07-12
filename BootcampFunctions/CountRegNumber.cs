
namespace BootcampFunctions;
public class CountRegNumber{

    public static int Execute(string Regs){
        return Regs.Split(",").Count();
    }
}