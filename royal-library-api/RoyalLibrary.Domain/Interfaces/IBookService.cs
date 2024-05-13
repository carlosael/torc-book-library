using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Domain.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync(string author, string isbn);
    }
}
