using Catalog.DAL.Contracts;
using Catalog.DAL.DataContext;
using Catalog.DAL.Entities;
using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Repository
{
    public class BookRepository : IBookRepository
    {
        readonly DatabaseContext _context;
        public BookRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<BookDTO> AddBook(BookDTO newBookForBd)
        {
            Book newBook = new Book
            {
                Id = newBookForBd.Id,
                Name = newBookForBd.Name,
                Author_Id = newBookForBd.Author_Id,
                Genre_Id = newBookForBd.Genre_Id,
                Status_Id = newBookForBd.Status_Id,
                AboutBook = newBookForBd.AboutBook
            };
            await _context.AddAsync<Book>(newBook);
            await _context.SaveChangesAsync();
            Book returnedBook = await _context.FindAsync<Book>(newBook.Id);

            return new BookDTO
            {
                Id = returnedBook.Id,
                Name = returnedBook.Name,
                Author_Id = returnedBook.Author_Id,
                Genre_Id = returnedBook.Genre_Id,
                Status_Id = returnedBook.Status_Id,
                AboutBook = returnedBook.AboutBook
            };
        }

        public async Task<BookDTO> ReadBook(long id)
        {


            Book returnedBookById = await _context.FindAsync<Book>(id);           

            BookDTO returnedDTObook = new BookDTO
            {
                Id = returnedBookById.Id,
                Name = returnedBookById.Name,
                AboutBook = returnedBookById.AboutBook,
                Author_Id = returnedBookById.Author_Id,
                Genre_Id = returnedBookById.Genre_Id,
                Status_Id = returnedBookById.Status_Id

            };
            return returnedDTObook;
        }

        public async Task<BookDTO> UpdateBook(BookDTO bookForUpdate)
        {
            Book forUpdate = new Book
            {
                Name = bookForUpdate.Name,
                AboutBook = bookForUpdate.AboutBook,
                Author_Id = bookForUpdate.Author_Id,
                Genre_Id = bookForUpdate.Genre_Id,
                Status_Id = bookForUpdate.Status_Id
            };

            Book returnedBook = await _context.FindAsync<Book>(bookForUpdate.Id);

            returnedBook.Name = forUpdate.Name;
            returnedBook.AboutBook = forUpdate.AboutBook;
            returnedBook.Author_Id = forUpdate.Author_Id;
            returnedBook.Genre_Id = forUpdate.Genre_Id;
            returnedBook.Status_Id = forUpdate.Status_Id;
            await _context.SaveChangesAsync();

            returnedBook = await _context.FindAsync<Book>(bookForUpdate.Id);
            return new BookDTO
            {
                Id = returnedBook.Id,
                Name = returnedBook.Name,
                Author_Id = returnedBook.Author_Id,
                Genre_Id = returnedBook.Genre_Id,
                Status_Id = returnedBook.Status_Id
            };
        }
    }
}
