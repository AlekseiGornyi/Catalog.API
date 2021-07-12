using Catalog.DAL.Contracts;
using Catalog.DAL.DataContext;
using Catalog.DAL.Entities;
using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Repository
{
    public class GenreRepository : IGenreRepository
    {
        readonly DatabaseContext _context;
        public GenreRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<GenreDTO> AddAGenre(GenreDTO newGenreForBd)
        {
            Genre newGenre = new Genre
            {
                Id = newGenreForBd.Id,
                Genres = newGenreForBd.Genres
            };

            await _context.AddAsync<Genre>(newGenre);
            await _context.SaveChangesAsync();
            Genre returnedGenre = await _context.FindAsync<Genre>(newGenre.Id);
           
            return new GenreDTO
            {
                Id = returnedGenre.Id,
                Genres = returnedGenre.Genres
            };
        }

        public async Task<GenreDTO> ReadGenre(long id)
        {

            Genre returnedGenreById = await _context.FindAsync<Genre>(id);

            GenreDTO returnedGenreDTO = new GenreDTO
            {
                Id = returnedGenreById.Id,
                Genres = returnedGenreById.Genres
            };

            return returnedGenreDTO;
        }

        public async Task<GenreDTO> UpdadeGenre(GenreDTO genreForUpdate)
        {
            Genre ForUpdate = new Genre
            {
                Genres = genreForUpdate.Genres
            };

            Genre returnedGenre = await _context.FindAsync<Genre>(genreForUpdate.Id);

            returnedGenre.Genres = ForUpdate.Genres;
            await _context.SaveChangesAsync();


            returnedGenre = await _context.FindAsync<Genre>(genreForUpdate.Id);
            return new GenreDTO
            {
                Id = returnedGenre.Id,
                Genres = returnedGenre.Genres
            };
        }
    }
}
