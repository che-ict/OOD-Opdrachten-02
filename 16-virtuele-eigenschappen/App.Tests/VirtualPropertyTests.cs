using App;

namespace App.Tests;

public class VirtualPropertyTests
{
    [Test]
    public void PdfDocument_FileType_ReturnsPdf()
    {
        Document doc = new PdfDocument();
        Assert.That(doc.FileType, Is.EqualTo("PDF"));
    }

    [Test]
    public void Document_FileType_ReturnsGenericDocument()
    {
        Document doc = new Document();
        Assert.That(doc.FileType, Is.EqualTo("Generiek Document"));
    }
}
