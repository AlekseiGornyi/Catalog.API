using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Contracts
{
    public interface IBookRepository
    {
        Task<BookDTO> AddBook(BookDTO newBookForBd);
        Task<BookDTO> ReadBook(long id);
        Task<BookDTO> UpdateBook(BookDTO bookForUpdate);
    }
}
