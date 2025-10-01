namespace App;

public static class Logger
{
    public static void PerformLog(ILoggable logger, string msg)
    {
        logger.Log(msg);
    }
}
