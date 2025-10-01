namespace App;

public static class OperationHandler
{
    public static string PerformOperation(int errorCode)
    {
        try
        {
            throw new OperationException(errorCode);
        }
        catch (OperationException ex) when (ex.ErrorCode == 500)
        {
            return "Kritieke fout";
        }
        catch (OperationException)
        {
            return "Andere fout";
        }
    }
}
