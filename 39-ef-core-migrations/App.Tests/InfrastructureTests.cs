using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests;

public class InfrastructureTests
{
    [Test]
    public void ContextCanBeCreatedWithInMemoryProvider()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<BlogContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        // Act & Assert
        using (var context = new BlogContext(options))
        {
            Assert.IsNotNull(context);
        }
    }

    [Test]
    public void CanAddBlogToInMemoryDatabase()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<BlogContext>()
            .UseInMemoryDatabase(databaseName: "Test_Add_Blog")
            .Options;

        using (var context = new BlogContext(options))
        {
            var blog = new Blog { Url = "http://testblog.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        // Assert
        using (var context = new BlogContext(options))
        {
            Assert.AreEqual(1, context.Blogs.Count());
            Assert.AreEqual("http://testblog.com", context.Blogs.Single().Url);
        }
    }
}