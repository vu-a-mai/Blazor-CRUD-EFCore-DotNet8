using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookCatalogDBContext : DbContext
    {
        public SimpleBookCatalogDBContext(DbContextOptions<SimpleBookCatalogDBContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        /*
            Fluent API Fluent API is a set of methods that allows you to configure the model.
        */
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Book>()
        //        .Property(b => b.Title)
        //        .IsRequired()
        //        .HasMaxLength(100);

        //     modelBuilder.Entity<Book>()
        //        .Property(b => b.Author)
        //        .IsRequired()
        //        .HasMaxLength(100);
        // }
    }
}