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
        var blog = _context.Blogs.Find(blogId);
        if (blog == null)
        {
            throw new Exception("Blog not found");
        }

        var post = new Post { Title = title, Content = content, BlogId = blogId };
        _context.Posts.Add(post);
        _context.SaveChanges();
        return post;
    }

    public List<Post> GetPostsForBlog(int blogId)
    {
        return _context.Posts.Where(p => p.BlogId == blogId).ToList();
    }

    public Blog? GetBlogWithPosts(int blogId)
    {
        return _context.Blogs.Include(b => b.Posts).FirstOrDefault(b => b.BlogId == blogId);
    }
}
