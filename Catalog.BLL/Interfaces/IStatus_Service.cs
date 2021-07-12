using Catalog.BLL.Models;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces
{
    public interface IStatus_Service
    {
        Task<Status_Resultset> AddStatus(string name);
        Task<Status_Resultset> GetStatus(long id);
        Task<Status_Resultset> UpdateStatus(long id, string name);
    }
}
