using Catalog.BLL.Interfaces;
using Catalog.BLL.Models;
using Catalog.BLL.Responce;
using Catalog.DAL.Contracts;
using Catalog.DAL.EntityDTO;
using System;
using System.Threading.Tasks;

namespace Catalog.BLL.Implementation
{
    public class Status_Service : IStatus_Service
    {
        private readonly IStatusRepository repo;
        
        public Status_Service(IStatusRepository _repo)
        {
            repo = _repo;
        }
        GenericResponse<Status_Resultset> gr = new GenericResponse<Status_Resultset>();
        public async Task<Status_Resultset> AddStatus(string name)
        {
            StatusDTO newStatus = new StatusDTO
            {
                Name = name
            };

            try
            {
                newStatus = await repo.AddStatus(newStatus);
                gr.isSuccess = true;
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(AddStatus), exception);
                gr.userMessage = string.Format(nameof(AddStatus), "error");
                gr.isSuccess = false;
            }

            Status_Resultset returnedStatus = new Status_Resultset
            {
                id = newStatus.Id,
                name = newStatus.Name
            };

            return returnedStatus;
        }

        public async Task<Status_Resultset> GetStatus(long id)
        {
            try
            {
                StatusDTO returnedStatus = await repo.ReadStatus(id);

                return new Status_Resultset
                {
                    id = returnedStatus.Id,
                    name = returnedStatus.Name
                };
            }
            catch (Exception exception)
            {
                gr.errorMessage = string.Format(nameof(GetStatus), exception);
                gr.userMessage = string.Format(nameof(GetStatus), "error");
            }

            return new Status_Resultset
            {
                name = "none"
            };
        }

        public async Task<Status_Resultset> UpdateStatus(long id, string name)
        {
            StatusDTO statusForUpdate = new StatusDTO
            {
                Id = id,
                Name = name
            };

            try
            {
                await repo.UpdadeStatus(statusForUpdate);
            }
            catch (Exception exception)
            {
                gr.errorMessage = string.Format(nameof(UpdateStatus), exception);
                gr.userMessage = string.Format(nameof(UpdateStatus), "error");
            }

            StatusDTO statusReturned = await repo.ReadStatus(id);

            return new Status_Resultset
            {
                id = statusReturned.Id,
                name = statusReturned.Name
            };
        }
    }
}
