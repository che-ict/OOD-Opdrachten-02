namespace App;

public static class Parser
{
    public static string ParseNumber(string input)
    {
        try
        {
            int.Parse(input);
            return "Succes";
        }
        catch (FormatException)
        {
            return "Ongeldig formaat";
        }
        catch (OverflowException)
        {
            return "Getal te groot";
        }
    }
}
