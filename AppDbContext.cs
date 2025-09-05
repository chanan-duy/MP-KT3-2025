using Microsoft.EntityFrameworkCore;

namespace MP_KT3_2025;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database1.db");
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e is { Entity: User, State: EntityState.Added or EntityState.Modified });

        foreach (var entry in entries)
        {
            var user = (User)entry.Entity;

            if (!user.IsValidDateOfBirth())
            {
                throw new RegistrationException($"User {user.Email} must be at least 14 years old");
            }
        }

        return base.SaveChanges();
    }
}
