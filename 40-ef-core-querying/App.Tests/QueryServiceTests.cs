using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace App.Tests;

public class QueryServiceTests
{
    private DbContextOptions<BlogContext> _options;

    [SetUp]
    public void Setup()
    {
        _options = new DbContextOptionsBuilder<BlogContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
    }

    private void SeedData(BlogContext context)
    {
        var blog1 = new Blog { Url = "http://b.com" };
        var blog2 = new Blog { Url = "http://a.com", Posts = new List<Post> { new Post { Title = "Post A1" } } };
        var blog3 = new Blog { Url = "http://c.com", Posts = new List<Post> { new Post { Title = "Post C1" }, new Post { Title = "Post C2" } } };

        context.Blogs.AddRange(blog1, blog2, blog3);
        context.SaveChanges();
    }

    [Test]
    public void GetBlogsOrderedByUrl_ShouldReturnBlogsInCorrectOrder()
    {
        using (var context = new BlogContext(_options))
        {
            SeedData(context);
            var service = new QueryService(context);

            var blogs = service.GetBlogsOrderedByUrl();

            Assert.AreEqual("http://a.com", blogs[0].Url);
            Assert.AreEqual("http://b.com", blogs[1].Url);
            Assert.AreEqual("http://c.com", blogs[2].Url);
        }
    }

    [Test]
    public void GetBlogsWithPosts_ShouldIncludePosts()
    {
        using (var context = new BlogContext(_options))
        {
            SeedData(context);
            var service = new QueryService(context);

            var blogs = service.GetBlogsWithPosts();

            var blogA = blogs.First(b => b.Url == "http://a.com");
            Assert.AreEqual(1, blogA.Posts.Count);

            var blogC = blogs.First(b => b.Url == "http://c.com");
            Assert.AreEqual(2, blogC.Posts.Count);
        }
    }

    [Test]
    public void GetBlogsByUrlFragment_ShouldReturnMatchingBlogs()
    {
        using (var context = new BlogContext(_options))
        {
            SeedData(context);
            var service = new QueryService(context);

            var blogs = service.GetBlogsByUrlFragment("a.com");

            Assert.AreEqual(1, blogs.Count);
            Assert.AreEqual("http://a.com", blogs[0].Url);
        }
    }

    [Test]
    public void GetPostsWithBlogUrl_ShouldReturnProjectedData()
    {
        using (var context = new BlogContext(_options))
        {
            SeedData(context);
            var service = new QueryService(context);

            dynamic posts = service.GetPostsWithBlogUrl();

            Assert.AreEqual(3, posts.Count);
            Assert.AreEqual("Post A1", posts[0].Title);
            Assert.AreEqual("http://a.com", posts[0].Url);
        }
    }

    [Test]
    public void GetPostCountPerBlog_ShouldReturnCorrectCounts()
    {
        using (var context = new BlogContext(_options))
        {
            SeedData(context);
            var service = new QueryService(context);

            dynamic counts = service.GetPostCountPerBlog();

            var blogA = ((IEnumerable<dynamic>)counts).First(c => c.BlogUrl == "http://a.com");
            Assert.AreEqual(1, blogA.NumberOfPosts);

            var blogB = ((IEnumerable<dynamic>)counts).First(c => c.BlogUrl == "http://b.com");
            Assert.AreEqual(0, blogB.NumberOfPosts);

            var blogC = ((IEnumerable<dynamic>)counts).First(c => c.BlogUrl == "http://c.com");
            Assert.AreEqual(2, blogC.NumberOfPosts);
        }
    }
}