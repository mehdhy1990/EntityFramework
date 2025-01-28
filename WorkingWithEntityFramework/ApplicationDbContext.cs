using Microsoft.EntityFrameworkCore;
using WorkingWithEntityFramework.Models;

namespace WorkingWithEntityFramework;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    
}