using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogForest.DataAccessLayer.Context;

public class BlogContext:IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog =BlogForestDb; User ID = SA; Password = Yasinyaman.43; Connect Timeout = 10; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Blog> Blogs { get; set; }
}