using Microsoft.Extensions.DependencyInjection;
using Catalog.DAL.Contracts;
using Catalog.DAL.Repository;
using Catalog.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DAL
{
    public static class ServiceCollection
    {
        public static void AddDALServices(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(connectionString,
            b => b.MigrationsAssembly("Catalog.DAL")));

            service.AddTransient<IBookRepository, BookRepository>();
            service.AddTransient<IAuthorRepository, AuthorRepository>();
            service.AddTransient<IGenreRepository, GenreRepository>();
            service.AddTransient<IStatusRepository, StatusRepository>();
        }
    }
}
