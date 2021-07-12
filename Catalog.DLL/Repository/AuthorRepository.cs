using Catalog.DAL.Contracts;
using Catalog.DAL.DataContext;
using Catalog.DAL.Entities;
using Catalog.DAL.EntityDTO;
using System.Threading.Tasks;

namespace Catalog.DAL.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        readonly DatabaseContext _context;

        public AuthorRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<AuthorDTO> AddAuthor(AuthorDTO newAuthorForBd)
        {
            Author newAuthor = new Author
            {
                Id = newAuthorForBd.Id,
                AuthorName = newAuthorForBd.AuthorName,
                AboutAuthor = newAuthorForBd.AboutAuthor
            };

            await _context.AddAsync<Author>(newAuthor);
            await _context.SaveChangesAsync();
            Author returnedAuthor = await _context.FindAsync<Author>(newAuthor.Id);            

            return new AuthorDTO
            {
                Id = returnedAuthor.Id,
                AuthorName = returnedAuthor.AuthorName,
                AboutAuthor = returnedAuthor.AboutAuthor
            };
        }


        public async Task<AuthorDTO> ReadAuthor(long id)
        {

            Author returnedAuthorById = await _context.FindAsync<Author>(id);


            AuthorDTO returnedAuthorDTO = new AuthorDTO
            {
                Id = returnedAuthorById.Id,
                AuthorName  = returnedAuthorById.AuthorName,
                AboutAuthor = returnedAuthorById.AboutAuthor
            };

            return returnedAuthorDTO;           

        }

        public async Task<AuthorDTO> UpdadeAuthor(AuthorDTO authorForUpdate)
        {
            Author ForUpdate = new Author
            {
                AuthorName = authorForUpdate.AuthorName,
                AboutAuthor = authorForUpdate.AboutAuthor

            };

            Author returnedAuthor = await _context.FindAsync<Author>(authorForUpdate.Id);

            returnedAuthor.AuthorName = ForUpdate.AuthorName;
            returnedAuthor.AboutAuthor = ForUpdate.AboutAuthor;
            await _context.SaveChangesAsync();            

            returnedAuthor = await _context.FindAsync<Author>(authorForUpdate.Id);
            return new AuthorDTO
            {
                Id = returnedAuthor.Id,
                AuthorName = returnedAuthor.AuthorName,
                AboutAuthor = returnedAuthor.AboutAuthor
            };
        }
    }
}
