using RoyalLibrary.Domain.Entities;
using RoyalLibrary.Domain.Interfaces;
using RoyalLibrary.Repository;

namespace RoyalLibrary.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) { 
            _bookRepository = bookRepository;
        }
        public async Task<List<Book>> GetAllAsync(string? author, string? isbn)
        {
            if (!string.IsNullOrEmpty(author))
            {
                return await _bookRepository.GetAllByAuthor(author.ToLower());
            }

            if (!string.IsNullOrEmpty(isbn))
            {
                return await _bookRepository.GetAllByIsbn(isbn);
            }

            return await _bookRepository.GetAllAsync();
        }
    }
}
