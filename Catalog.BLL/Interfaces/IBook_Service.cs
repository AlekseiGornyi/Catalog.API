using Catalog.BLL.Models;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces
{
    public interface IBook_Service
    {
        Task<Book_Resultset> AddBook(string name, string about_book, long author_id, long genre_id, long status_id);
        Task<Book_Resultset> GetBook(long id);
        Task<Book_Resultset> UpdateBook(long id, string name, string about_book, long author_id, long genre_id, long status_id);
    }
}
