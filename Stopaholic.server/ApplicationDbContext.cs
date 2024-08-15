using Microsoft.EntityFrameworkCore;
using Stopaholic.Shared.Models; 
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define DbSets for your models
    public DbSet<User> Users { get; set; }
    public DbSet<MonthlyList> MonthlyWantLists { get; set; }
    public DbSet<Item> WantItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configuration can go here
    }
}
