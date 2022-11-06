using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace eCommerce.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skills_Book>().HasKey(am => new
            {
                am.SkillId,
                am.BookId
            });
            modelBuilder.Entity<Skills_Book>().HasOne(b => b.Book).WithMany(am => am.Skills_Book).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Skills_Book>().HasOne(b => b.Skill).WithMany(am => am.Skills_Book).HasForeignKey(b => b.SkillId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Skills> Skills { get; set; }
        public DbSet<Skills_Book> Skills_Book { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Publication> Publication { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
