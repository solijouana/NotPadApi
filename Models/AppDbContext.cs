using System;
using Microsoft.EntityFrameworkCore;

namespace NotePad_api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(new Note()
            {
                Id = "1",
                title = "note 1",
                note = "note sample 1",
                CreateDate = DateTime.Now,
                sync = false
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}