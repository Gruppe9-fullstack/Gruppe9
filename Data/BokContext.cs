using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;

public class BokContext : DbContext
{
    public DbSet<Bok> Bok { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Bibliotek_gruppe9.db");

    }
}