using Backend.WebApi.Data.Config;
using Backend.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

public class BackendDB : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\Jan\OneDrive\Desktop\Ordner\Authentification\WebApp\DB\Authentification.db");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Name> Names { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new NameConfiguration());
    }
}