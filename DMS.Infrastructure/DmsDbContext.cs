using DMS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DMS.Infrastructure
{
    public class DmsDbContext : DbContext
    {
        public DbSet<Pdf> Pdfs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source=documents.db");
        }
    }
}
