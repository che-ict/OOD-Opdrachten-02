using Microsoft.EntityFrameworkCore;

namespace App;

public class QueryService
{
    private readonly BlogContext _context;

    public QueryService(BlogContext context)
    {
        _context = context;
    }

    public List<Blog> GetBlogsOrderedByUrl()
    {
        return _context.Blogs.OrderBy(b => b.Url).ToList();
    }

    public List<Blog> GetBlogsWithPosts()
    {
        return _context.Blogs.Include(b => b.Posts).ToList();
    }

    public List<Blog> GetBlogsByUrlFragment(string fragment)
    {
        return _context.Blogs.Where(b => b.Url.Contains(fragment)).ToList();
    }

    public object GetPostsWithBlogUrl()
    {
        return _context.Posts
            .Select(p => new { p.Title, p.Blog.Url })
            .ToList();
    }

    public object GetPostCountPerBlog()
    {
        return _context.Blogs
            .Select(b => new { BlogUrl = b.Url, NumberOfPosts = b.Posts.Count })
            .ToList();
    }
}
