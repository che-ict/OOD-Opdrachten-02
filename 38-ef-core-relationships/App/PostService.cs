using Microsoft.EntityFrameworkCore;

namespace App;

public class PostService
{
    private readonly BlogContext _context;

    public PostService(BlogContext context)
    {
        _context = context;
    }

    public Post AddPost(int blogId, string title, string content)
    {
        // TODO: Implement adding a new post to a specific blog
        throw new NotImplementedException();
    }

    public List<Post> GetPostsForBlog(int blogId)
    {
        // TODO: Implement retrieving all posts for a specific blog
        throw new NotImplementedException();
    }

    public Blog? GetBlogWithPosts(int blogId)
    {
        // TODO: Implement retrieving a blog and its associated posts
        throw new NotImplementedException();
    }
}
