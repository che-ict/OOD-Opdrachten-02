using App;

namespace App.Tests;

public class ExceptionFilterTests
{
    [Test]
    public void PerformOperation_ReturnsKritiekeFout_WhenErrorCodeIs500()
    {
        Assert.That(OperationHandler.PerformOperation(500), Is.EqualTo("Kritieke fout"));
    }

    [Test]
    public void PerformOperation_ReturnsAndereFout_WhenErrorCodeIsNot500()
    {
        Assert.That(OperationHandler.PerformOperation(404), Is.EqualTo("Andere fout"));
        Assert.That(OperationHandler.PerformOperation(200), Is.EqualTo("Andere fout"));
    }
}
