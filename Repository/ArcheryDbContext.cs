using ArcheryScorecard.Models;
using Microsoft.EntityFrameworkCore;

namespace ArcheryScorecard.Repository;

public class ArcheryDbContext : DbContext
{
    public DbSet<Tournament> Tournaments { get; set; }

    public ArcheryDbContext(DbContextOptions<ArcheryDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity relationships if needed
    }
}
