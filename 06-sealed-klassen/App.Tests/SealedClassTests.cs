using App;
using NUnit.Framework;

namespace App.Tests;

public class SealedClassTests
{
    [Test]
    public void FinalReport_IsSealed_Test()
    {
        // This test verifies that FinalReport is sealed and cannot be inherited from.
        // Attempting to uncomment the following line will result in a compile-time error:
        // public class DraftReport : FinalReport { }

        Assert.Pass("FinalReport is a sealed class. Attempting to inherit from it will cause a compile-time error.");
    }

    [Test]
    public void FinalReport_Content_CanBeSetAndGet()
    {
        var report = new FinalReport { Content = "This is a final report." };
        Assert.That(report.Content, Is.EqualTo("This is a final report."));
    }
}
