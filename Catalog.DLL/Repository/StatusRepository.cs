using Catalog.DAL.Contracts;
using Catalog.DAL.DataContext;
using Catalog.DAL.Entities;
using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Repository
{
    public class StatusRepository : IStatusRepository
    {
        readonly DatabaseContext _context;

        public StatusRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<StatusDTO> AddStatus(StatusDTO newStatusForDb)
        {
            Status newStatus = new Status
            {
                Name = newStatusForDb.Name
            };

            await _context.AddAsync<Status>(newStatus);
            await _context.SaveChangesAsync();
            Status returnedStatus = await _context.FindAsync<Status>(newStatus.Id);

            return new StatusDTO
            {
                Id = returnedStatus.Id,
                Name = returnedStatus.Name
            };
        }

        public async Task<StatusDTO> ReadStatus(long id)
        {

            Status returnedStatusById = await _context.FindAsync<Status>(id);          

            StatusDTO statusReturned = new StatusDTO
            {
                Id = returnedStatusById.Id,
                Name = returnedStatusById.Name
            };

            return statusReturned;

        }

        public async Task<StatusDTO> UpdadeStatus(StatusDTO statusForUpdate)
        {

            Status ForUpdate = new Status
            {
                Name = statusForUpdate.Name
            };

            Status returnedStatus = await _context.FindAsync<Status>(statusForUpdate.Id);

            returnedStatus.Name = ForUpdate.Name;
            await _context.SaveChangesAsync();

            /*StatusDTO updatedStatus = new StatusDTO
            {
                Id = returnedStatus.Id,
                Name = returnedStatus.Name,
                Book_id = returnedStatus.Book_id,
                
            };

            return updatedStatus;*/

            returnedStatus = await _context.FindAsync<Status>(statusForUpdate.Id);
            return new StatusDTO
            {
                Id = returnedStatus.Id,
                Name = returnedStatus.Name
            };
        }

    }
}
