using System;

namespace MicroBlogAPI.Repository.Dto
{
    public class PostDto
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime Created { get; set; }
    }
}
