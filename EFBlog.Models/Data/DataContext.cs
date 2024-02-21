using Microsoft.EntityFrameworkCore;

namespace EFBlog.Models.Data
{
    public class DataContext<T> : DbContext
    {
        
        public DataContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            
        }
    }
}