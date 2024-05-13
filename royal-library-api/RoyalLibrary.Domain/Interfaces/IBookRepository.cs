using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Repository
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();

        Task<List<Book>> GetAllByAuthor(string author);

        Task<List<Book>> GetAllByIsbn(string isbn);
    }
}
