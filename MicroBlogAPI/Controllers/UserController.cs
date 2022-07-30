using MicroBlogAPI.Models;
using MicroBlogAPI.Repository;
using MicroBlogAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroBlogAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser repo;

        public UserController(IUser repo)
        {
            this.repo = repo;
        }
        [AllowAnonymous]
        [HttpPost("Authenicate")]
        public IActionResult Authenicate([FromBody] User model) 
        {
            var user = repo.Authenicate(model.Username, model.Password);

            if(user == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult 

    }
}
