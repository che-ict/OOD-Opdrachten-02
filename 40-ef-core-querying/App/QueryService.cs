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
        // TODO: Implement a query to get all blogs ordered by URL
        throw new NotImplementedException();
    }

    public List<Blog> GetBlogsWithPosts()
    {
        // TODO: Implement a query to get all blogs including their posts
        throw new NotImplementedException();
    }

    public List<Blog> GetBlogsByUrlFragment(string fragment)
    {
        // TODO: Implement a query to get blogs whose URL contains a specific fragment
        throw new NotImplementedException();
    }

    public object GetPostsWithBlogUrl()
    {
        // TODO: Implement a query to get post titles and their associated blog URLs
        throw new NotImplementedException();
    }

    public object GetPostCountPerBlog()
    {
        // TODO: Implement a query to get the number of posts for each blog
        throw new NotImplementedException();
    }
}
