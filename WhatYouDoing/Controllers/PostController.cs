using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WYWT.Models;



namespace WYWT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostContext _context;

        public PostController(PostContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/values
        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            Console.Write("jsis");
            if (post == null)
            {
                return BadRequest();
            }

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return Ok();
            //return CreatedAtRoute(nameof(GetAllPosts),new { id = value.Id }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
