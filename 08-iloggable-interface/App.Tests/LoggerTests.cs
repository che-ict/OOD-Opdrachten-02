using App;

namespace App.Tests;

public class LoggerTests
{
    [Test]
    public void DatabaseLogger_LogsMessageCorrectly()
    {
        var dbLogger = new DatabaseLogger();
        Logger.PerformLog(dbLogger, "Testbericht");
        Assert.That(dbLogger.LastMessage, Is.EqualTo("Testbericht"));
    }

    [Test]
    public void FileLogger_LogsMessageCorrectly()
    {
        var fileLogger = new FileLogger();
        Logger.PerformLog(fileLogger, "Bestandsbericht");
        Assert.That(fileLogger.LastMessage, Is.EqualTo("Bestandsbericht"));
    }
}
