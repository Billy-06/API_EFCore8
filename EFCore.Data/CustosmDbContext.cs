using Microsoft.EntityFrameworkCore;
using EFCore.Domain;

namespace EFCore.Data;

public class CustomDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasOne<Coach>(t => t.Coach).WithMany(c => c.Teams).HasForeignKey(t => t.CoachId);
        modelBuilder.Entity<Player>().HasOne<Team>(p => p.Team).WithMany(t => t.Players).HasForeignKey(p => p.TeamId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FootballTable; Encrypt=False");
    }
    public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
    {
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Coach> Coaches { get; set; }
}
