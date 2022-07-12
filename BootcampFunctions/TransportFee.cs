namespace BootcampFunctions;

public class TransportFee
{
    public static string Execute(string shift){
        if(shift == "morning"){
            return "R20";
        }
        else if(shift == "afternoon"){
            return "R10";
        }
        else{
            return "free";
        }
    }
}