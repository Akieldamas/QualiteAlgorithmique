// See https://aka.ms/new-console-template for more information
public class Program
{
    public string GetSignal(bool isGreen, bool isYellow, bool isRed)
    {
        if (isGreen)
        {
            return "Green Signal";
        }
        else
        {
            if (isYellow)
            {
                return "Yellow Signal";
            }
            else
            {
                if (isRed)
                {
                    return "Red Signal";
                }
                else
                {
                    return "No Signal";
                }
            }
        }
    }
}