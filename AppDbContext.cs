using Microsoft.EntityFrameworkCore;

namespace MP_KT3_2025;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database1.db");
    }
}
