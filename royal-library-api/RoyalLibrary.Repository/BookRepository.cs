using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<List<Book>> GetAllByAuthor(string author)
        {
            return await _context.Books.Where(x => (x.FirstName + " " + x.LastName).ToLower().Contains(author)).ToListAsync();
        }

        public async Task<List<Book>> GetAllByIsbn(string isbn)
        {
            return await _context.Books.Where(x => x.Isbn.Contains(isbn)).ToListAsync();
        }
    }
}
