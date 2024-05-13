using Microsoft.AspNetCore.Mvc;
using RoyalLibrary.Domain.Entities;
using RoyalLibrary.Domain.Interfaces;

namespace royal_library_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService) {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> Get([FromQuery] string? author, [FromQuery] string? isbn)
        {
            return await _bookService.GetAllAsync(author, isbn);
        }

    }
}
