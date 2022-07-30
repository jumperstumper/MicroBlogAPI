using AutoMapper;
using MicroBlogAPI.Models;
using MicroBlogAPI.Repository;
using MicroBlogAPI.Repository.Dto;

namespace MicroBlogAPI.Mappings
{
    public class PostMappings : Profile
    {
        public PostMappings()
        {
            CreateMap<Post, PostDto>().ReverseMap();
        }
    }
}
