using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    builder.Entity<Province>().Property(m => m.ProvinceCode).IsRequired();

    builder.Entity<City>().Property(p => p.ProvinceCode).HasMaxLength(30);

    builder.Entity<City>().ToTable("City");
    builder.Entity<Province>().ToTable("Province");

    builder.Seed();
}
}
}

