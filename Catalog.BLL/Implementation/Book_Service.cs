using Catalog.BLL.Interfaces;
using Catalog.BLL.Models;
using Catalog.BLL.Responce;
using Catalog.DAL.Contracts;
using Catalog.DAL.EntityDTO;
using System;
using System.Threading.Tasks;

namespace Catalog.BLL.Implementation
{
    public class Book_Service : IBook_Service
    {
        private readonly IBookRepository repo;
        public Book_Service(IBookRepository _repo)
        {
            repo = _repo;
        }

        GenericResponse<Book_Resultset> gr = new GenericResponse<Book_Resultset>();

        public async Task<Book_Resultset> AddBook(string name, string about_book, long author_id, long genre_id, long status_id)
        {
            BookDTO newBook = new BookDTO
            {
               Name = name,
               AboutBook = about_book,
               Author_Id = author_id,
               Genre_Id = genre_id,
               Status_Id = status_id
            };

            try
            {
                newBook = await repo.AddBook(newBook);
                gr.isSuccess = true;
            }
            catch (Exception exception)
            {
                gr.errorMessage = string.Format(nameof(AddBook), exception);
                gr.userMessage = string.Format(nameof(AddBook), "error");
                gr.isSuccess = false;
            }          

            Book_Resultset returnedBook_Resultset = new Book_Resultset
            {
                id = newBook.Id,
                name = newBook.Name,
                aboutBook = newBook.AboutBook,
                author_Id = newBook.Author_Id,
                genre_Id = newBook.Genre_Id,
                status_Id = newBook.Status_Id                
            };

            return returnedBook_Resultset;
        }

        public async Task<Book_Resultset> GetBook(long id)
        {
            try
            {
                BookDTO returnedBook = await repo.ReadBook(id);

                return new Book_Resultset
                {
                    id = returnedBook.Id,
                    name = returnedBook.Name,
                    aboutBook = returnedBook.AboutBook,
                    author_Id = returnedBook.Author_Id,
                    genre_Id = returnedBook.Genre_Id,
                    status_Id = returnedBook.Status_Id
                };
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(GetBook), exception);
                gr.userMessage = string.Format(nameof(GetBook), "error");
            }

            return new Book_Resultset
            {
                name = "none"
            };
        }

        public async Task<Book_Resultset> UpdateBook(long id, string name, string about_book, long author_id, long genre_id, long status_id)
        {
            BookDTO bookForUpdate = new BookDTO
            {
                Id = id,
                Name = name,
                AboutBook = about_book,
                Author_Id = author_id,
                Genre_Id = genre_id,
                Status_Id = status_id
            };

            try
            {
                await repo.UpdateBook(bookForUpdate);
            }
            catch (Exception exception)
            {
                gr.errorMessage = string.Format(nameof(UpdateBook), exception);
                gr.userMessage = string.Format(nameof(UpdateBook), "error");
            }

            BookDTO bookReturned = await repo.ReadBook(id);

            return new Book_Resultset
            {
                id = bookReturned.Id,
                name = bookReturned.Name,
                aboutBook = bookReturned.AboutBook,
                author_Id = bookReturned.Author_Id,
                genre_Id = bookReturned.Genre_Id,
                status_Id = bookReturned.Status_Id
            };
        }
    }
}
