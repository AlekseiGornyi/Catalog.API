using Catalog.BLL.Implementation;
using Catalog.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Catalog.BLL
{
    public static class ServiceCollection
    {
        public static void AddBLLServices(this IServiceCollection service)
        {
            service.AddTransient<IStatus_Service, Status_Service>();
            service.AddTransient<IAuthor_Service, Author_Service>();
            service.AddTransient<IGenre_Service, Genre_Service>();
            service.AddTransient<IBook_Service, Book_Service>();
        }
    }
}
