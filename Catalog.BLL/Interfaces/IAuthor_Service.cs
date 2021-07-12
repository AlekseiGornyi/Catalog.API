using Catalog.BLL.Models;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces
{
    public interface IAuthor_Service
    {
        Task<Author_Resultset> AddAuthor(string name, string aboutAuthor);
        Task<Author_Resultset> GetAuthor(long id);
        Task<Author_Resultset> UpdateAuthor(long id, string name, string aboutAuthor);

        //Task<Generic_Resultset<Author_Resultset>> AddAutor();
    }
}
