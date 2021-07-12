using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Contracts
{
    public interface IGenreRepository
    {
        Task<GenreDTO> AddAGenre(GenreDTO newGenreForBd);
        Task<GenreDTO> ReadGenre(long id);
        Task<GenreDTO> UpdadeGenre(GenreDTO genreForUpdate);
    }
}
