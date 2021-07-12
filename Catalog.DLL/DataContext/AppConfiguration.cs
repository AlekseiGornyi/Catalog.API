using System.IO;
using Microsoft.Extensions.Configuration;

namespace Catalog.DAL.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            // ConfigurationBuilder используется для получения данных из config/settings для построение 
            // key/value структуры (как словарь)
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            // Указываем место расположения appsettings.json для path
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            // Передаем данные переменной path в configurationBuilder
            configurationBuilder.AddJsonFile(path, false);

            // Построение configurationBuilder и присвоение результата (полученние структуры) в объект root
            IConfigurationRoot root = configurationBuilder.Build();

            // Передаем key для объекта root
            IConfigurationSection appSettings = root.GetSection("ConnectionStrings:DefaultConnection");

            // Добавление key value в sqlConnectionVariable чтобы мы могли получить к ним доступ после инициализации класса
            SqlConnectionString = appSettings.Value;
        }
        public string SqlConnectionString { get; set; }
    }
}
