namespace App;

public class BlogService
{
    private readonly BlogContext _context;

    public BlogService(BlogContext context)
    {
        _context = context;
    }

    public Blog AddBlog(string url)
    {
        var blog = new Blog { Url = url };
        _context.Blogs.Add(blog);
        _context.SaveChanges();
        return blog;
    }

    public List<Blog> GetAllBlogs()
    {
        return _context.Blogs.ToList();
    }

    public Blog? GetBlog(int blogId)
    {
        return _context.Blogs.Find(blogId);
    }

    public void UpdateBlogUrl(int blogId, string newUrl)
    {
        var blog = _context.Blogs.Find(blogId);
        if (blog != null)
        {
            blog.Url = newUrl;
            _context.SaveChanges();
        }
    }

    public void DeleteBlog(int blogId)
    {
        var blog = _context.Blogs.Find(blogId);
        if (blog != null)
        {
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
        }
    }
}
