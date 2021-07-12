using Catalog.API.Models.Book;
using Catalog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook_Service _book_service;

        public BookController(IBook_Service book_service)
        {
            _book_service = book_service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddBook(string name, string about_book, long author_id, long genre_id, long status_id)
        {
            var result = await _book_service.AddBook(name, about_book, author_id, genre_id, status_id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBookId(long id)
        {
            var result = await _book_service.GetBook(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateAuthour(BookUpdate_Pass_Object book)
        {
            var result = await _book_service.UpdateBook(book.id, book.name, book.about_book, book.author_id, book.genre_id, book.status_id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

    }
}
