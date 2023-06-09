﻿using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;

public class BokContext : DbContext
{
    public DbSet<Bok> Bok { get; set; }
    public DbSet<Eksemplar> Eksemplar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Eksemplar>()
            .HasKey(e => e.EksNr);

        modelBuilder.Entity<Eksemplar>()
            .HasOne(e => e.Bok)
            .WithMany(b => b.Eksemplar)
            .HasForeignKey(e => e.ISBN);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine("Data", "Bibliotek_gruppe9.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
