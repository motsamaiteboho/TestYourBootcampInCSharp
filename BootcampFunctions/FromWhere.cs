namespace BootcampFunctions;

public class FromWhere
{
    public static string Execute(string Reg)
    {
        if (Reg.StartsWith("CY")){
            return "Bellville";
        }
        else if (Reg.StartsWith("CJ")){
            return "Paarl";
        }
        else if (Reg.StartsWith("CA")){
            return "Cape Town";
        }
        else{
            return "Some other place!";
        }
    }
}