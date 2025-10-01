using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests;

public class BlogContextTests
{
    [Test]
    public void CanAddAndSaveChangesToDatabase()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<BlogContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new BlogContext(options))
        {
            var blog = new Blog { Url = "http://example.com" };

            // Act
            context.Blogs.Add(blog);
            context.SaveChanges();

            // Assert
            Assert.AreNotEqual(0, blog.BlogId);
        }
    }
}