using MicroBlogAPI.Models;
using System.Collections.Generic;

namespace MicroBlogAPI.Repository.IRepository
{
    public interface IPostRepo
    {
        ICollection<Post> GetPosts();
        Post GetPost(int id);

        bool CreatePost(Post post);
        bool DeletePost(int id);
        bool UpdatePost(Post post);
        bool Save();
    }
}
