using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests;

public class PostServiceTests
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
    public void AddPost_ShouldAddPostToBlog()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var blog = new Blog { Url = "http://test.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();

            var service = new PostService(context);

            // Act
            service.AddPost(blog.BlogId, "Test Title", "Test Content");

            // Assert
            var blogWithPosts = context.Blogs.Include(b => b.Posts).First();
            Assert.AreEqual(1, blogWithPosts.Posts.Count);
            Assert.AreEqual("Test Title", blogWithPosts.Posts[0].Title);
        }
    }

    [Test]
    public void GetPostsForBlog_ShouldReturnAllPostsForBlog()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var blog = new Blog { Url = "http://test.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();

            var service = new PostService(context);
            service.AddPost(blog.BlogId, "Title 1", "Content 1");
            service.AddPost(blog.BlogId, "Title 2", "Content 2");

            // Act
            var posts = service.GetPostsForBlog(blog.BlogId);

            // Assert
            Assert.AreEqual(2, posts.Count);
        }
    }

    [Test]
    public void GetBlogWithPosts_ShouldIncludePosts()
    {
        // Arrange
        using (var context = new BlogContext(_options))
        {
            var blog = new Blog { Url = "http://test.com" };
            context.Blogs.Add(blog);
            context.SaveChanges();

            var service = new PostService(context);
            service.AddPost(blog.BlogId, "Test Title", "Test Content");

            // Act
            var blogWithPosts = service.GetBlogWithPosts(blog.BlogId);

            // Assert
            Assert.IsNotNull(blogWithPosts);
            Assert.AreEqual(1, blogWithPosts.Posts.Count);
            Assert.AreEqual("Test Title", blogWithPosts.Posts[0].Title);
        }
    }
}