using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;


namespace Catalog.DAL.Contracts
{
    public interface IStatusRepository
    {
        Task<StatusDTO> AddStatus(StatusDTO newStatusForBd);
        Task<StatusDTO> ReadStatus(long id);
        Task<StatusDTO> UpdadeStatus(StatusDTO statusForUpdate);
        //Task<List<BookDTO>> GetBooksStatus(long id);
    }
}
