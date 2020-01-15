using System;
using Microsoft.EntityFrameworkCore;
namespace WYWT.Models
{
   
    public class PostContext : DbContext
     {

        public PostContext(DbContextOptions<PostContext> options) : base(options)
         {

         }
        public DbSet<Post> Posts { get; set; }
    }
        

    public class Post
    {
        public long Id { get; set; }
        public string MovieTitle { get; set; }
        public string DateTime { get; set; }
        public string UserName { get; set; }
    }
}
