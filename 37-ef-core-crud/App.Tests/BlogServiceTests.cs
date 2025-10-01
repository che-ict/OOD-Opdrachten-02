using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests;

public class BlogServiceTests
{
    private DbContextOptions<BlogContext> _options;

    [SetUp]
    public void Setup()
    {
        _options = new DbContextOptionsBuilder<BlogContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
    }

    [Test]
    public void AddBlog_ShouldAddBlogToDatabase()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var service = new BlogService(context);

            // Act
            service.AddBlog("http://test.com");

            // Assert
            Assert.AreEqual(1, context.Blogs.Count());
            Assert.AreEqual("http://test.com", context.Blogs.First().Url);
        }
    }

    [Test]
    public void GetAllBlogs_ShouldReturnAllBlogs()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            context.Blogs.Add(new Blog { Url = "http://test1.com" });
            context.Blogs.Add(new Blog { Url = "http://test2.com" });
            context.SaveChanges();
            var service = new BlogService(context);

            // Act
            var blogs = service.GetAllBlogs();

            // Assert
            Assert.AreEqual(2, blogs.Count);
        }
    }

    [Test]
    public void GetBlog_ShouldReturnCorrectBlog()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var addedBlog = new Blog { Url = "http://test.com" };
            context.Blogs.Add(addedBlog);
            context.SaveChanges();
            var service = new BlogService(context);

            // Act
            var blog = service.GetBlog(addedBlog.BlogId);

            // Assert
            Assert.IsNotNull(blog);
            Assert.AreEqual("http://test.com", blog.Url);
        }
    }

    [Test]
    public void UpdateBlogUrl_ShouldUpdateUrl()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var blog = new Blog { Url = "http://original.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();
            var service = new BlogService(context);

            // Act
            service.UpdateBlogUrl(blog.BlogId, "http://updated.com");

            // Assert
            var updatedBlog = context.Blogs.Find(blog.BlogId);
            Assert.IsNotNull(updatedBlog);
            Assert.AreEqual("http://updated.com", updatedBlog.Url);
        }
    }

    [Test]
    public void DeleteBlog_ShouldRemoveBlogFromDatabase()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var blog = new Blog { Url = "http://test.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();
            var service = new BlogService(context);

            // Act
            service.DeleteBlog(blog.BlogId);

            // Assert
            Assert.AreEqual(0, context.Blogs.Count());
        }
    }
}