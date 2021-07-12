using Catalog.BLL.Interfaces;
using Catalog.BLL.Models;
using Catalog.BLL.Responce;
using Catalog.DAL.Contracts;
using Catalog.DAL.EntityDTO;
using System;
using System.Threading.Tasks;

namespace Catalog.BLL.Implementation
{
    public class Genre_Service : IGenre_Service
    {
        private readonly IGenreRepository repo;
        public Genre_Service(IGenreRepository _repo)
        {
            repo = _repo;
        }
        GenericResponse<Genre_Resultset> gr = new GenericResponse<Genre_Resultset>();


        public async Task<Genre_Resultset> AddGenre(string genre)
        {
            GenreDTO newGenre = new GenreDTO
            {
                Genres = genre
            };

            try
            {
                newGenre = await repo.AddAGenre(newGenre);
                gr.isSuccess = true;
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(AddGenre), exception);
                gr.userMessage = string.Format(nameof(AddGenre), "error");
                gr.isSuccess = false;
            }

            Genre_Resultset returnedGenre_Resultset = new Genre_Resultset
            {
                id = newGenre.Id,
                genres = newGenre.Genres
            };

            return returnedGenre_Resultset;
        }

        public async Task<Genre_Resultset> GetGenre(long id)
        {
            try
            {
                GenreDTO returnedGenre = await repo.ReadGenre(id);
                gr.isSuccess = true;
                return new Genre_Resultset
                {
                    id = returnedGenre.Id,
                    genres = returnedGenre.Genres                    
                };
                
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(GetGenre), exception);
                gr.userMessage = string.Format(nameof(GetGenre), "error");
                gr.isSuccess = false;
            }

            return new Genre_Resultset
            {
                genres = "none"
            };
        }

        public async Task<Genre_Resultset> UpdateGenre(long id, string genre)
        {
            GenreDTO genreForUpdate = new GenreDTO
            {
                Id = id,
                Genres = genre
            };

            try
            {
                await repo.UpdadeGenre(genreForUpdate);
            }
            catch(Exception exception)
            {
                gr.errorMessage = string.Format(nameof(UpdateGenre), exception);
                gr.userMessage = string.Format(nameof(UpdateGenre), "error");
            }

            GenreDTO genreReturned = await repo.ReadGenre(id);
            return new Genre_Resultset
            {
                id = genreReturned.Id,
                genres = genreReturned.Genres
            };
        }
    }
}
