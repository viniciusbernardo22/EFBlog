using EFBlog.Data.Mappings;
using EFBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace EFBlog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EFBlog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

        //Usar mapeamentos
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new CategoryMap());
            mb.ApplyConfiguration(new PostMap());
            mb.ApplyConfiguration(new UserMap());
        }
    }
}