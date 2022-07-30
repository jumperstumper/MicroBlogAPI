using System;
using System.ComponentModel.DataAnnotations;

namespace MicroBlogAPI.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Message { get; set; }
    
        public DateTime Created { get; set; }
        //[Required]
        //public string User { get; set; }
    }
}
