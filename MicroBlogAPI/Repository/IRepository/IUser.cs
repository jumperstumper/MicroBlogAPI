using MicroBlogAPI.Models;

namespace MicroBlogAPI.Repository.IRepository
{
    public interface IUser
    {
        bool IsUniqueUser(string username);
        User Authenicate(string username, string password);
        User Register(string username, string password);

    }
}
