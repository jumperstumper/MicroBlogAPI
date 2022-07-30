using MicroBlogAPI.Data;
using MicroBlogAPI.Models;
using MicroBlogAPI.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace MicroBlogAPI.Repository
{
    public class PostRepo : IPostRepo
    {
        private ApplicationDbContext _db;

        public PostRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreatePost(Post post)
        {
            _db.Post.Add(post);

            return Save();
        }

        public bool DeletePost(int id)
        {
            var obj = _db.Post.FirstOrDefault(x => x.Id == id);
            _db.Post.Remove(obj);
            return Save();
        }

        public Post GetPost(int id)
        {
            return _db.Post.FirstOrDefault(x => x.Id == id);
           
        }

        public ICollection<Post> GetPosts()
        {
            return _db.Post.OrderBy(x => x.Created).ToList();
        }

        public bool Save()
        {
           return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdatePost(Post post)
        {

            _db.Post.Update(post);
            return Save();
        }
    }
}
