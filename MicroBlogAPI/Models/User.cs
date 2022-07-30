using System.ComponentModel.DataAnnotations.Schema;

namespace MicroBlogAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Country { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
        [NotMapped]
        public string Token { get; set; }

    }
}
