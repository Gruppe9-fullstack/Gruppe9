using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;

public class BokContext : DbContext
{
    public DbSet<Bok> Bok { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine("Data", "Bibliotek_gruppe9.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }

}