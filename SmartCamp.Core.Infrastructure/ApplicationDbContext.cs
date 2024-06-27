using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCamp.Core.Domain.Entities;

namespace SmartCamp.Core.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Camp> Camps { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    private void Seed(ModelBuilder builder)
    {
        var roles = new List<IdentityRole>
        {
            new IdentityRole()
            {
                Id = "048897f2-04c3-4467-a853-6b73b1e80adc",
                Name = "Admin",
                NormalizedName = "ADMIN"
            }
        };

        builder.Entity<IdentityRole>().HasData(roles);
    }
}
