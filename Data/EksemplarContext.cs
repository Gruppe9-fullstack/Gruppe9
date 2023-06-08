using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;

public class EksemplarContext : DbContext
{
    public DbSet<Eksemplar> Eksemplar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Bibliotek_gruppe9.db");
    }
}