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
        // TODO: Implement adding a new blog to the database
        throw new NotImplementedException();
    }

    public List<Blog> GetAllBlogs()
    {
        // TODO: Implement retrieving all blogs from the database
        throw new NotImplementedException();
    }

    public Blog? GetBlog(int blogId)
    {
        // TODO: Implement retrieving a single blog by its ID
        throw new NotImplementedException();
    }

    public void UpdateBlogUrl(int blogId, string newUrl)
    {
        // TODO: Implement updating the URL of an existing blog
        throw new NotImplementedException();
    }

    public void DeleteBlog(int blogId)
    {
        // TODO: Implement deleting a blog by its ID
        throw new NotImplementedException();
    }
}
