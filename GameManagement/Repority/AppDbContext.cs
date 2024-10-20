using GameManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace GameManagement.Repority;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Game> Games { get; set; }
}