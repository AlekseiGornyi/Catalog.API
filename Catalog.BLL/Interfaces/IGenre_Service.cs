using Catalog.BLL.Models;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces
{
    public interface IGenre_Service
    {
        Task<Genre_Resultset> AddGenre(string genre);
        Task<Genre_Resultset> GetGenre(long id);
        Task<Genre_Resultset> UpdateGenre(long id, string genre);
    }
}
