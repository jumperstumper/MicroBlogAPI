using AutoMapper;
using MicroBlogAPI.Data;
using MicroBlogAPI.Models;
using MicroBlogAPI.Repository.Dto;
using MicroBlogAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MicroBlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepo _repo;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;

        public PostController(IPostRepo repo, IMapper mapper, ApplicationDbContext db)
        {
            _repo = repo;
            _mapper = mapper;
            _db = db;
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create([FromBody] PostDto dto)
        {
            try
            {
                if (dto == null)
                {
                    return NotFound();
                }

                var obj = _mapper.Map<Post>(dto);
                _repo.CreatePost(obj);


                return Ok();
            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }

            return NotFound();
        }

        [Route("GetFields")]
        [HttpGet]
        public IActionResult GetFields()
        {
            try
            {

                Post obj = new Post()
                {
                    Created = System.DateTime.Now,
                    Message = "",
                };



                return Ok(obj);
            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }

            return NotFound();
        }

        [Route("Edit")]
        [HttpPatch]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (post == null)
                {
                    return NoContent();
                }

               var edit = _repo.UpdatePost(post);


            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }

            return Ok();
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {

                var AllPost = _repo.GetPosts().OrderByDescending(x => x.Id).Take(10);

                if (AllPost == null)
                {
                    return NotFound("There are no posts");
                }

                return Ok(AllPost);

            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }
        }
        [Route("GetPost")]
        [HttpGet]
        public IActionResult GetPost(int id)
        {
            try
            {

             var post =  _repo.GetPost(id);

                if (post == null)
                {
                    return NotFound();
                }

             return Ok(post);

            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }

        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            try
            {
                var post = _repo.DeletePost(id);

            }
            catch (System.Exception)
            {

                return StatusCode(500);
            }
         
            return Ok();
        }


    }
}
