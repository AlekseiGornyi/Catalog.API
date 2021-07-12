using Catalog.BLL.Interfaces;
using Catalog.BLL.Models;
using Catalog.DAL.EntityDTO;
using Catalog.DAL.Contracts;
using System;
using System.Threading.Tasks;
using Catalog.BLL.Responce;

namespace Catalog.BLL.Implementation
{
    public class Author_Service : IAuthor_Service
    {       
        private readonly IAuthorRepository repo;       

        public Author_Service(IAuthorRepository _repo)
        {
            repo = _repo;           
        }

        GenericResponse<Author_Resultset> gr = new GenericResponse<Author_Resultset>();


        public async Task<Author_Resultset> AddAuthor(string name, string aboutAuthor)
        {           
            AuthorDTO newAuthor = new AuthorDTO
            {                
                AuthorName = name,
                AboutAuthor = aboutAuthor
            };

            try
            {
                newAuthor = await repo.AddAuthor(newAuthor);
                gr.isSuccess = true;
            }
            catch (Exception exception)
            {
                gr.errorMessage = string.Format("nameof(AddAuthor)", exception);
                gr.userMessage = string.Format("nameof(AddAuthor)", "error");
                gr.isSuccess = false;
            }

            Author_Resultset returnedAuthor_Resultset = new Author_Resultset
            {
                id = newAuthor.Id,
                authorName = newAuthor.AuthorName,
                aboutAuthor = newAuthor.AboutAuthor
            };

            return returnedAuthor_Resultset;
        }

        public async Task<Author_Resultset> GetAuthor(long id)
        {
            try
            {
                AuthorDTO returnedAuthor = await repo.ReadAuthor(id);
                gr.isSuccess = true;

                return new Author_Resultset
                {
                    id = returnedAuthor.Id,
                    authorName = returnedAuthor.AuthorName,
                    aboutAuthor = returnedAuthor.AboutAuthor
                };
                
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(GetAuthor), exception);
                gr.userMessage = string.Format(nameof(GetAuthor), "error");
                gr.isSuccess = false;

            }

            return new Author_Resultset
            {
                authorName = "none"
            };
        }

        public async Task<Author_Resultset> UpdateAuthor(long id, string name, string aboutAuthor)
        {
            AuthorDTO authorForUpdate = new AuthorDTO
            {
                Id = id,
                AuthorName = name,
                AboutAuthor = aboutAuthor
            };

            try
            {
                await repo.UpdadeAuthor(authorForUpdate);
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(UpdateAuthor), exception);
                gr.userMessage = string.Format(nameof(UpdateAuthor), "error");
            }

            AuthorDTO authorReturned = await repo.ReadAuthor(id);

            return new Author_Resultset
            {
                id = authorReturned.Id,
                authorName = authorReturned.AuthorName,
                aboutAuthor = authorReturned.AboutAuthor
            };
                    
        }   
    }
}
