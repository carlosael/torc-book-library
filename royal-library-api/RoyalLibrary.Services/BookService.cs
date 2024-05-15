using RoyalLibrary.Domain.Entities;
using RoyalLibrary.Domain.Handlers;
using RoyalLibrary.Domain.Interfaces;
using RoyalLibrary.Repository;

namespace RoyalLibrary.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        private readonly IDispatcher _dispatcher;

        public BookService(IBookRepository bookRepository, IDispatcher dispatcher) {
            _bookRepository = bookRepository;
            _dispatcher = dispatcher;

        }
        public async Task<List<Book>> GetAllAsync(string? author, string? isbn)
        {
            _dispatcher.Publish(new BookSearchEvent("New book search"));

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
