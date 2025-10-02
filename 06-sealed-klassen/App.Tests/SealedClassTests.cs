using App;
using NUnit.Framework;

namespace App.Tests;

public class SealedClassTests
{
    [Test]
    public void FinalReport_IsSealed_Test()
    {
        var typeVar = typeof(FinalReport);
        Assert.That(typeVar.IsSealed, Is.True, "Class is not sealed");
    }

    [Test]
    public void FinalReport_Content_CanBeSetAndGet()
    {
        var report = new FinalReport { Content = "This is a final report." };
        Assert.That(report.Content, Is.EqualTo("This is a final report."));
    }
}
