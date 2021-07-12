using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Contracts
{
    public interface IAuthorRepository
    {
        Task<AuthorDTO> AddAuthor(AuthorDTO newAuthorForBd);
        Task<AuthorDTO> ReadAuthor(long id);
        Task<AuthorDTO> UpdadeAuthor(AuthorDTO authorForUpdate);
    }
}
