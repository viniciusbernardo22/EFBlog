using EFBlog.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EFBlog.Models.Data
{
    public class BlogDataContext : DbContext
    {
        public BlogDataContext()
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
       // public DbSet<PostTag> PostsTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
       // public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
            
        
    }
}