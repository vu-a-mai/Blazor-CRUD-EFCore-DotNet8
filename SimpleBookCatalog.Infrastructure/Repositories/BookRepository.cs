using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Domain.Entities;
using SimpleBookCatalog.Infrastructure.Context;

namespace SimpleBookCatalog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleBookCatalogDBContext context;
        public BookRepository(IDbContextFactory<SimpleBookCatalogDBContext> contextFactory)
        {
            context = contextFactory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }
    }
}