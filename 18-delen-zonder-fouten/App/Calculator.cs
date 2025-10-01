namespace App;

public static class Calculator
{
    public static int SafeDivide(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            return 0;
        }
    }
}
